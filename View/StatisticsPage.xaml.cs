using System.Data;
using System.Windows;
using TachyDev1.Utility;
using WPF = System.Windows;


namespace TachyDev1.View;


public partial class StatisticsPage : WPF.Controls.Page
{
    public StatisticsPage()
    {
        InitializeComponent();

        UpdateRatingScoreValue();
    }

    private bool UpdateRatingScoreValue()
    {
        DataTable? reservationsTable = ACCESSor.LoadTable("Reservation");
        if (reservationsTable == null) return false;

        var count = reservationsTable.Rows.Count;
        int sum = 0;


        foreach (DataRow reservation in reservationsTable.Rows)
        {
            try
            {
                int score = int.Parse(reservation["RatingScore"].ToString());
                sum += score;
            } catch { }
        }

        double avg = sum / (double)count;
        this.RatingScoreValue.Text = $"{avg}/5";

        return true;
    }
}
