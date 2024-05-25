﻿// This file was auto-generated by ML.NET Model Builder.
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace ConsoleApp1
{
    public partial class MLModel1
    {
        /// <summary>
        /// model input class for MLModel1.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [LoadColumn(0)]
            [ColumnName(@"longitude")]
            public float Longitude { get; set; }

            [LoadColumn(1)]
            [ColumnName(@"latitude")]
            public float Latitude { get; set; }

            [LoadColumn(2)]
            [ColumnName(@"housing_median_age")]
            public float Housing_median_age { get; set; }

            [LoadColumn(3)]
            [ColumnName(@"total_rooms")]
            public float Total_rooms { get; set; }

            [LoadColumn(4)]
            [ColumnName(@"total_bedrooms")]
            public float Total_bedrooms { get; set; }

            [LoadColumn(5)]
            [ColumnName(@"population")]
            public float Population { get; set; }

            [LoadColumn(6)]
            [ColumnName(@"households")]
            public float Households { get; set; }

            [LoadColumn(7)]
            [ColumnName(@"median_income")]
            public float Median_income { get; set; }

            [LoadColumn(8)]
            [ColumnName(@"median_house_value")]
            public float Median_house_value { get; set; }

            [LoadColumn(9)]
            [ColumnName(@"ocean_proximity")]
            public string Ocean_proximity { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for MLModel1.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"longitude")]
            public float Longitude { get; set; }

            [ColumnName(@"latitude")]
            public float Latitude { get; set; }

            [ColumnName(@"housing_median_age")]
            public float Housing_median_age { get; set; }

            [ColumnName(@"total_rooms")]
            public float Total_rooms { get; set; }

            [ColumnName(@"total_bedrooms")]
            public float Total_bedrooms { get; set; }

            [ColumnName(@"population")]
            public float Population { get; set; }

            [ColumnName(@"households")]
            public float Households { get; set; }

            [ColumnName(@"median_income")]
            public float Median_income { get; set; }

            [ColumnName(@"median_house_value")]
            public float Median_house_value { get; set; }

            [ColumnName(@"ocean_proximity")]
            public float[] Ocean_proximity { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"Score")]
            public float Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("MLModel1.mlnet");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);


        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }
    }
}