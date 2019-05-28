//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace Ml.netSalesPredictionML.Model.DataModels
{
    public class ModelInput
    {
        [ColumnName("Month"), LoadColumn(0)]
        public string Month { get; set; }


        [ColumnName("ProductSales"), LoadColumn(1)]
        public float ProductSales { get; set; }


    }
}
