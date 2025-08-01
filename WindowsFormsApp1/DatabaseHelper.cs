﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class DatabaseHelper
    {
        public static async Task<DataTable> ExecuteQueryAsync(string query, Dictionary<string, object> parameters = null, bool useLinkQv = false)
        {
            //SqlCommand command = await CreateCommandAsync(query, parameters, useLinkQv);

            //using (var adapter = new SqlDataAdapter(command))
            //{
            //    var resultTable = new DataTable();
            //    await Task.Run(() => adapter.Fill(resultTable)); // Wrapping `Fill` in `Task.Run` for async behavior
            //    Center.closeConnection();

            //    return resultTable;
            //}

            SqlCommand command = await CreateCommandAsync(query, parameters, useLinkQv);
            DataTable resultTable = new DataTable();

            using (var reader = await command.ExecuteReaderAsync())
            {
                resultTable.Load(reader);
            }

            Center.closeConnection();
            return resultTable;
        }

        public static async Task<int> ExecuteNonQueryAsync(string query, Dictionary<string, object> parameters = null, bool useLinkQv = false)
        {
            SqlCommand command = await CreateCommandAsync(query, parameters, useLinkQv);
            int result = await command.ExecuteNonQueryAsync();
            Center.closeConnection();
            return result;
        }

        //guaranteed all-or-nothing:
        public static async Task<int> ExecuteNonQueryWithTransactionAsync(string query, Dictionary<string, object> parameters = null, bool useLinkQv = false)
        {
            if (useLinkQv)
                await Task.Run(() => Center.openConnection_LinkQvDB());
            else
                await Task.Run(() => Center.openConnection_WindsorDB());

            using (var transaction = Center.con.BeginTransaction())
            using (var command = Center.con.CreateCommand())
            {
                command.Transaction = transaction;
                command.CommandText = query;
                command.CommandTimeout = 600;

                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                try
                {
                    int result = await command.ExecuteNonQueryAsync();
                    await Task.Run(() => transaction.Commit());
                    //transaction.Commit();
                    return result;
                }
                catch (Exception ex)
                {
                    await Task.Run(() => transaction.Rollback());
                    //transaction.Rollback();
                    Center.closeConnection();
                    Logger.Log("Transaction failed", ex);
                    throw; // rethrow to handle it outside if needed
                }
                finally
                {
                    Center.closeConnection();
                }
            }
        }



        public static async Task<object> ExecuteScalarAsync(string query, Dictionary<string, object> parameters = null, bool useLinkQv = false)
        {
            SqlCommand command = await CreateCommandAsync(query, parameters, useLinkQv);
            object result = await command.ExecuteScalarAsync();
            Center.closeConnection();
            return result;
        }

        private static async Task<SqlCommand> CreateCommandAsync(string query, Dictionary<string, object> parameters, bool useLinkQv)
        {
            // Open the appropriate connection
            if (useLinkQv)
                await Task.Run(() => Center.openConnection_LinkQvDB());
            else
                await Task.Run(() => Center.openConnection_WindsorDB());

            // Create and configure the command
            SqlCommand command = new SqlCommand(query, Center.con)
            {
                CommandTimeout = 600
            };

            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }
            }

            return command;
        }
    }
}
