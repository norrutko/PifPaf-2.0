using System;

namespace Strzelnica
{
    public class Player : IComparable<Player>
    {
        public string Nick { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public int[] Month { get; set; } = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int[] MonthPercentage { get; set; } = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int TotalScore { get; set; } = 0;
        public int TotalScorePercentage { get; set; } = 0;

        public int CompareTo(Player other)
        {
            return this.TotalScorePercentage.CompareTo(other.TotalScorePercentage);
        }
        public int CompareTo(Player other, int index)
        {
            return this.MonthPercentage[index].CompareTo(other.MonthPercentage[index]);
        }
    }
}
