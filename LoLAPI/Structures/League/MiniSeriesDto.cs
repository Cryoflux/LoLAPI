namespace LoLAPI.Structures.League
{
    public struct MiniSeriesDto
    {
        //This object contains mini series information.
        public int losses { get; set; } //Number of current losses in the mini series.
        public string progress { get; set; } /*String showing the current, sequential mini series progress where 'W' represents a win, 'L' represents a loss, and 'N'
                                             represents a game that hasn't been played yet.*/
        public int target { get; set; } //Number of wins required for promotion.
        public int wins { get; set; } //Number of current wins in the mini series.
    }
}
