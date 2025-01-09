using Microsoft.ML.Data;

public class SentimentData
{
    [ColumnName("Sentiment"), LoadColumn(0)]
    public bool Sentiment { get; set; }
    [ColumnName("SentimentText"), LoadColumn(1)]
    public string SentimentText { get; set; } = default!;

}
public class SentimentPrediction : SentimentData
{
    [ColumnName("PredictedLabel")]
    public bool Prediction { get; set; }
    public float Probability { get; set; }
    public float Score { get; set; }
}