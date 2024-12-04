using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DataTransfer
    {
        public async Task<int> TransferDataAsync(string orderNumber, string batchNumber)
        {
            int totalRowsAffected = 0;
            try
            {
               
              
                // Step 1: Fetch Data from Source Database
                DataTable sourceData = await FetchDataFromSourceAsync(orderNumber, batchNumber);

              
                // Step 2: Insert Data into Target Database
                if (sourceData.Rows.Count > 0)
                {
                    totalRowsAffected = await InsertDataToTargetAsync(sourceData);
                    Console.WriteLine("Data transfer completed successfully.");
                }
                else
                {
                    Console.WriteLine("No data found for the specified order.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during data transfer: {ex.Message}");
            }
            return totalRowsAffected;

        }

        private async Task<DataTable> FetchDataFromSourceAsync(string orderNumber, string batchNumber)
        {
            Center.Location = 2;
            string query = @"
                SELECT 
                    OrderType, [Order], @batch AS Batch, ProjectName, PlotNumber, BluePrintName, ConfirmationDate,
                    [System], Color, TotalQuantity, CustomerName, Position, Code, Quantity, UnitPrice,
                    TotalPrice, Dimensions, sfabName, sfabCodeName, ProductionNoteDescription, OtherDescription, GETDATE() AS TimeStamp
                FROM [10.100.14.85].[ITBIZM].[site].[e2e_order_detail] AS s
                JOIN [10.100.14.85].[ITBIZM].[prefsuite].[e2e_SubModelDetail] AS p ON s.[Order] = p.OrderNumber
                JOIN [10.100.14.85].[ITBIZM].[master].[vw_fab_detail] AS f ON s.Manufac_Set = f.sfabName
                WHERE s.[Order] = @order";

            var parameters = new Dictionary<string, object>
            {
                { "@order", orderNumber },
                { "@batch", batchNumber }
            };

            return await DatabaseHelper.ExecuteQueryAsync(query, parameters, useLinkQv: true);
        }

        private async Task<int> InsertDataToTargetAsync(DataTable data)
        {
            Center.Location = 3;
            string insertQuery = @"
                INSERT INTO [tblOrderDetail] (
                    [OrderType], [Order], [Batch], [ProjectName], [PlotNumber], [BluePrintName], [ConfirmationDate], 
                    [System], [Color], [TotalQuantity], [CustomerName], [Position], [Code], [Quantity], [UnitPrice], 
                    [TotalPrice], [Dimensions], [sfabName], [sfabCodeName], [ProductionNoteDescription], [OtherDescription], [TimeStamp]
                )
                VALUES (
                    @OrderType, @Order, @Batch, @ProjectName, @PlotNumber, @BluePrintName, @ConfirmationDate, 
                    @System, @Color, @TotalQuantity, @CustomerName, @Position, @Code, @Quantity, @UnitPrice, 
                    @TotalPrice, @Dimensions, @sfabName, @sfabCodeName, @ProductionNoteDescription, @OtherDescription, @TimeStamp
                )";
            int totalRowsAffected = 0;

            foreach (DataRow row in data.Rows)
            {
                var parameters = new Dictionary<string, object>
                {
                    { "@OrderType", row["OrderType"] },
                    { "@Order", row["Order"] },
                    { "@Batch", row["Batch"] },
                    { "@ProjectName", row["ProjectName"] },
                    { "@PlotNumber", row["PlotNumber"] },
                    { "@BluePrintName", row["BluePrintName"] },
                    { "@ConfirmationDate", row["ConfirmationDate"] },
                    { "@System", row["System"] },
                    { "@Color", row["Color"] },
                    { "@TotalQuantity", row["TotalQuantity"] },
                    { "@CustomerName", row["CustomerName"] },
                    { "@Position", row["Position"] },
                    { "@Code", row["Code"] },
                    { "@Quantity", row["Quantity"] },
                    { "@UnitPrice", row["UnitPrice"] },
                    { "@TotalPrice", row["TotalPrice"] },
                    { "@Dimensions", row["Dimensions"] },
                    { "@sfabName", row["sfabName"] },
                    { "@sfabCodeName", row["sfabCodeName"] },
                    { "@ProductionNoteDescription", row["ProductionNoteDescription"] },
                    { "@OtherDescription", row["OtherDescription"] },
                    { "@TimeStamp", row["TimeStamp"] }
                };

                totalRowsAffected += await DatabaseHelper.ExecuteNonQueryAsync(insertQuery, parameters, useLinkQv: false);
            }
            return totalRowsAffected;
        }
    }
}
