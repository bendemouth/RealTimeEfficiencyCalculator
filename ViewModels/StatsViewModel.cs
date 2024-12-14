using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EfficiencyCalculator.ViewModels
{
    public class StatsViewModel : INotifyPropertyChanged // Implement INotifyPropertyChanged interface to update stats in real time
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string properyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(properyName));
        }

        // Team stats
        private int tmFgTwoMade;
        public int TmFgTwoMade
        {
            get => tmFgTwoMade;
            set
            {
                if (tmFgTwoMade != value)
                {
                    tmFgTwoMade = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(TeamFieldGoalShooting));
                    OnPropertyChanged(nameof(TeamEfg));
                    OnPropertyChanged(nameof(TeamPoss));
                    OnPropertyChanged(nameof(TeamOffEfficiency));
                    OnPropertyChanged(nameof(OppDefEfficiency));
                }
            }
        }

        private int tmFgTwoMiss;
        public int TmFgTwoMiss
        {
            get => tmFgTwoMiss;
            set
            {
                if (tmFgTwoMiss != value)
                {
                    tmFgTwoMiss = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(TeamFieldGoalShooting));
                    OnPropertyChanged(nameof(TeamEfg));
                    OnPropertyChanged(nameof(TeamPoss));
                    OnPropertyChanged(nameof(TeamOffEfficiency));
                    OnPropertyChanged(nameof(OppDefEfficiency));
                }
            }
        }

        private int tmFgThreeMade;
        public int TmFgThreeMade
        {
            get => tmFgThreeMade;
            set
            {
                if (tmFgThreeMade != value)
                {
                    tmFgThreeMade = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(TeamFieldGoalShooting));
                    OnPropertyChanged(nameof(TeamThreePointShooting));
                    OnPropertyChanged(nameof(TeamEfg));
                    OnPropertyChanged(nameof(TeamPoss));
                    OnPropertyChanged(nameof(TeamOffEfficiency));
                    OnPropertyChanged(nameof(OppDefEfficiency));
                }
            }
        }

        private int tmFgThreeMiss;
        public int TmFgThreeMiss
        {
            get => tmFgThreeMiss;
            set
            {
                if (tmFgThreeMiss != value)
                {
                    tmFgThreeMiss = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(TeamFieldGoalShooting));
                    OnPropertyChanged(nameof(TeamThreePointShooting));
                    OnPropertyChanged(nameof(TeamEfg));
                    OnPropertyChanged(nameof(TeamPoss));
                    OnPropertyChanged(nameof(TeamOffEfficiency));
                    OnPropertyChanged(nameof(OppDefEfficiency));
                }
            }
        }

        private int tmOrb;
        public int TmOrb
        {
            get => tmOrb;
            set
            {
                if (tmOrb != value)
                {
                    tmOrb = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(TeamPoss));
                    OnPropertyChanged(nameof(TeamOrbPct));
                    OnPropertyChanged(nameof(TeamOffEfficiency));
                    OnPropertyChanged(nameof(OppDefEfficiency));
                }
            }
        }

        private int tmDrb;
        public int TmDrb
        {
            get => tmDrb;
            set
            {
                if (tmDrb != value)
                {
                    tmDrb = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(TeamDrbPct));
                }
            }
        }

        private int tmFtMade;
        public int TmFtMade
        {
            get => tmFtMade;
            set
            {
                if (tmFtMade != value)
                {
                    tmFtMade = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(TeamPoss));
                    OnPropertyChanged(nameof(TeamOffEfficiency));
                    OnPropertyChanged(nameof(OppDefEfficiency));
                }
            }
        }

        private int tmFtMiss;
        public int TmFtMiss
        {
            get => tmFtMiss;
            set
            {
                if (tmFtMiss != value)
                {
                    tmFtMiss = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(TeamPoss));
                    OnPropertyChanged(nameof(TeamOffEfficiency));
                    OnPropertyChanged(nameof(OppDefEfficiency));
                }
            }
        }

        private int tmTov;
        public int TmTov
        {
            get => tmTov;
            set
            {
                if (tmTov != value)
                {
                    tmTov = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(TeamPoss));
                    OnPropertyChanged(nameof(TeamOffEfficiency));
                    OnPropertyChanged(nameof(OppDefEfficiency));
                }
            }
        }

        // Opponent stats
        private int oppFgTwoMade;
        public int OppFgTwoMade
        {
            get => oppFgTwoMade;
            set
            {
                if (oppFgTwoMade != value)
                {
                    oppFgTwoMade = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(OppFieldGoalShooting));
                    OnPropertyChanged(nameof(OppEfg));
                    OnPropertyChanged(nameof(OppPoss));
                    OnPropertyChanged(nameof(OppOffEfficiency));
                    OnPropertyChanged(nameof(TeamDefEfficiency));
                }
            }
        }

        private int oppFgTwoMiss;
        public int OppFgTwoMiss
        {
            get => oppFgTwoMiss;
            set
            {
                if (oppFgTwoMiss != value)
                {
                    oppFgTwoMiss = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof (OppFieldGoalShooting));
                    OnPropertyChanged(nameof(OppEfg));
                    OnPropertyChanged(nameof(OppPoss));
                    OnPropertyChanged(nameof(OppOffEfficiency));
                    OnPropertyChanged(nameof(TeamDefEfficiency));
                }
            }
        }

        private int oppFgThreeMade;
        public int OppFgThreeMade
        {
            get => oppFgThreeMade;
            set
            {
                if (oppFgThreeMade != value)
                {
                    oppFgThreeMade = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(OppFieldGoalShooting));
                    OnPropertyChanged(nameof(OppThreePointShooting));
                    OnPropertyChanged(nameof(OppEfg));
                    OnPropertyChanged(nameof(OppPoss));
                    OnPropertyChanged(nameof(OppOffEfficiency));
                    OnPropertyChanged(nameof(TeamDefEfficiency));
                }
            }
        }

        private int oppFgThreeMiss;
        public int OppFgThreeMiss
        {
            get => oppFgThreeMiss;
            set
            {
                if (oppFgThreeMiss != value)
                {
                    oppFgThreeMiss = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(OppFieldGoalShooting));
                    OnPropertyChanged(nameof(OppThreePointShooting));
                    OnPropertyChanged(nameof(OppEfg));
                    OnPropertyChanged(nameof(OppPoss));
                    OnPropertyChanged(nameof(OppOffEfficiency));
                    OnPropertyChanged(nameof(TeamDefEfficiency));
                }
            }
        }

        private int oppOrb;
        public int OppOrb
        {
            get => oppOrb;
            set
            {
                if (oppOrb != value)
                {
                    oppOrb = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(OppPoss));
                    OnPropertyChanged(nameof(TeamDrbPct));
                    OnPropertyChanged(nameof(OppOffEfficiency));
                    OnPropertyChanged(nameof(TeamDefEfficiency));
                }
            }
        }

        private int oppDrb;
        public int OppDrb
        {
            get => oppDrb;
            set
            {
                if (oppDrb != value)
                {
                    oppDrb = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(TeamOrbPct));
                }
            }
        }

        private int oppFtMade;
        public int OppFtMade
        {
            get => oppFtMade;
            set
            {
                if (oppFtMade != value)
                {
                    oppFtMade = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(OppPoss));
                    OnPropertyChanged(nameof(OppOffEfficiency));
                    OnPropertyChanged(nameof(TeamDefEfficiency));
                }
            }
        }

        private int oppFtMiss;
        public int OppFtMiss
        {
            get => oppFtMiss;
            set
            {
                if (oppFtMiss != value)
                {
                    oppFtMiss = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(OppPoss));
                    OnPropertyChanged(nameof(OppOffEfficiency));
                    OnPropertyChanged(nameof(TeamDefEfficiency));
                }
            }
        }

        private int oppTov;
        public int OppTov
        {
            get => oppTov;
            set
            {
                if (oppTov != value)
                {
                    oppTov = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(OppPoss));
                    OnPropertyChanged(nameof(OppOffEfficiency));
                    OnPropertyChanged(nameof(TeamDefEfficiency));
                }
            }
        }

        private int tmPts;
        public int TmPts
        {
            get => tmPts;
            set
            {
                if (tmPts != value)
                {
                    tmPts = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(TeamOffEfficiency));
                    OnPropertyChanged(nameof(OppDefEfficiency));
                }
            }
        }

        private int oppPts;
        public int OppPts
        {
            get => oppPts;
            set
            {
                if (oppPts != value)
                {
                    oppPts = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(OppOffEfficiency));
                    OnPropertyChanged(nameof(TeamDefEfficiency));
                }
            }
        }

        // Static FT coefficient based on KenPom. Used in possession calculation
        const double FT_COEFF = 0.44;

        // Team Total Field Goal Shooting String
        public string TeamFieldGoalShooting
        {
            get
            {
                int totalMakes = TmFgTwoMade + TmFgThreeMade;
                int totalAttempts = totalMakes + TmFgTwoMiss + TmFgThreeMiss;
                double totalPercent = totalAttempts > 0 ? ((double)totalMakes / totalAttempts) * 100 : 0;

                return $"Team Field Goal Shooting: {totalMakes}-{totalAttempts} - {totalPercent:F2}%";
            }
        }

        // Team Three Point Shooting String
        public string TeamThreePointShooting
        {
            get
            {
                int totalMakes = TmFgThreeMade;
                int totalAttempts = TmFgThreeMade + TmFgThreeMiss;
                double totalPercent = totalAttempts > 0 ? ((double)totalMakes / totalAttempts) * 100 : 0;

                return $"Team Three-Point Shooting: {totalMakes}-{totalAttempts} - {totalPercent:F2}%";
            }
        }

        // Opp Total Field Goal Shooting String 
        public string OppFieldGoalShooting
        {
            get
            {
                int totalMakes = OppFgTwoMade + OppFgThreeMade;
                int totalAttempts = totalMakes + OppFgTwoMiss + OppFgThreeMiss;
                double totalPercent = totalAttempts > 0 ? ((double)totalMakes / totalAttempts) * 100 : 0;

                return $"Opponent Field Goal Shooting: {totalMakes}-{totalAttempts} - {totalPercent:F2}%";
            }
        }

        // Opp Three Point Shooting String
        public string OppThreePointShooting
        {
            get
            {
                int totalMakes = OppFgThreeMade;
                int totalAttempts = OppFgThreeMade + OppFgThreeMiss;
                double totalPercent = totalAttempts > 0 ? ((double)totalMakes / totalAttempts) * 100 : 0;

                return $"Opponent Three-Point Shooting: {totalMakes}-{totalAttempts} - {totalPercent:F2}%";
            }
        }

        // Team eFG String
        public string TeamEfg
        {
            get
            {
                int totalAttempts = tmFgTwoMade + tmFgThreeMade + tmFgTwoMiss + tmFgThreeMiss;
                double efg = totalAttempts > 0 ? ((double)TmFgTwoMade + TmFgThreeMade + (0.5 * TmFgThreeMade)) / totalAttempts : 0;

                return $"Team eFG%: {efg:F2}%";
            }
        }

        // Opp eFG String
        public string OppEfg
        {
            get
            {
                int totalAttempts = oppFgTwoMade + oppFgThreeMade + oppFgTwoMiss + oppFgThreeMiss;
                double efg = totalAttempts > 0 ? ((double)OppFgTwoMade + OppFgThreeMade + (0.5 * OppFgThreeMade)) / totalAttempts : 0;

                return $"Opponent eFG%: {efg:F2}%";
            }
        }

        // Team possession string
        public string TeamPoss
        {
            get
            {
                int totalFieldGoalAttempts = tmFgTwoMade + tmFgThreeMade + tmFgTwoMiss + tmFgThreeMiss;
                int totalFreeThrowAttempts = tmFtMade + tmFtMiss;
                double totalTmPoss = (double)(totalFieldGoalAttempts - TmOrb) + TmTov + (FT_COEFF * totalFreeThrowAttempts);

                return $"Team Possessions (Estimate): {totalTmPoss:F2}";
            }
        }

        // Opp possession string
        public string OppPoss
        {
            get
            {
                int totalFieldGoalAttempts = oppFgTwoMade + oppFgThreeMade + oppFgTwoMiss + oppFgThreeMiss;
                int totalFreeThrowAttempts = oppFtMade + oppFtMiss;
                double totalOppPoss = (double)(totalFieldGoalAttempts - OppOrb) + OppTov + (FT_COEFF * totalFreeThrowAttempts);

                return $"Opponent Possessions (Estimate): {totalOppPoss:F2}";
            }
        }

        public string TeamOffEfficiency
        {
            get
            {
                int totalFieldGoalAttempts = tmFgTwoMade + tmFgThreeMade + tmFgTwoMiss + tmFgThreeMiss;
                int totalFreeThrowAttempts = tmFtMade + tmFtMiss;
                double totalTmPoss = (double)(totalFieldGoalAttempts - TmOrb) + TmTov + (FT_COEFF * totalFreeThrowAttempts);

                double tmOffEff = totalTmPoss > 0 ? (double)TmPts / totalTmPoss : 0;

                return $"Team Offensive Efficiency: {tmOffEff:F2}";
            }
        }

        public string TeamDefEfficiency
        {
            get
            {
                int totalFieldGoalAttempts = oppFgTwoMade + oppFgThreeMade + oppFgTwoMiss + oppFgThreeMiss;
                int totalFreeThrowAttempts = oppFtMade + oppFtMiss;
                double totalOppPoss = (double)(totalFieldGoalAttempts - OppOrb) + OppTov + (FT_COEFF * totalFreeThrowAttempts);

                double tmDefEff = totalOppPoss > 0 ? (double)OppPts / totalOppPoss : 0;

                return $"Team Defensive Efficiency: {tmDefEff:F2}";
            }
        }

        public string OppOffEfficiency
        {
            get
            {
                int totalFieldGoalAttempts = oppFgTwoMade + oppFgThreeMade + oppFgTwoMiss + oppFgThreeMiss;
                int totalFreeThrowAttempts = oppFtMade + oppFtMiss;
                double totalOppPoss = (double)(totalFieldGoalAttempts - OppOrb) + OppTov + (FT_COEFF * totalFreeThrowAttempts);

                double oppOffEff = totalOppPoss > 0 ? (double)OppPts / totalOppPoss : 0;

                return $"Opponent Offensive Efficiency: {oppOffEff:F2}";
            }
        }

        public string OppDefEfficiency
        {
            get
            {
                int totalFieldGoalAttempts = tmFgTwoMade + tmFgThreeMade + tmFgTwoMiss + tmFgThreeMiss;
                int totalFreeThrowAttempts = tmFtMade + tmFtMiss;
                double totalTmPoss = (double)(totalFieldGoalAttempts - TmOrb) + TmTov + (FT_COEFF * totalFreeThrowAttempts);

                double oppDefEff = totalTmPoss > 0 ? (double)TmPts / totalTmPoss : 0;

                return $"Opponent Defensive Efficiency: {oppDefEff:F2}";
            }
        }

        public string TeamOrbPct
        {
            get
            {
                double orbPct;

                if (TmOrb > 0 || OppDrb > 0)
                {
                    orbPct = (double)TmOrb / (TmOrb + OppDrb);
                }

                else
                {
                    orbPct = 0;
                }

                return $"Team Offensive Rebounding Percent: {orbPct:F2}%";
            }
        }

        public string TeamDrbPct
        {
            get
            {
                double drbPct;
                if (TmDrb > 0 || OppOrb > 0)
                {
                    drbPct = (double)TmDrb / (TmDrb + OppOrb);
                }

                else
                {
                    drbPct = 0;
                }

                return $"Team Defensive Rebounding Percent: {drbPct:F2}%";
            }
        }

        public string OppOrbPct
        {
            get
            {
                double orbPct;

                if (oppOrb > 0 || TmDrb > 0)
                {
                    orbPct = (double)OppOrb / (oppOrb + TmDrb);
                }

                else
                {
                    orbPct = 0;
                }

                return $"Opponent Offensive Rebounding Percent: {orbPct:F2}%";
            }
        }

        public string OppDrbPct
        {
            get
            {
                double drbPct;
                if (oppDrb > 0 || TmOrb > 0)
                {
                    drbPct = (double)OppDrb / (OppDrb + TmOrb);
                }

                else
                {
                    drbPct = 0;
                }
                

                return $"Opponent Defensive Rebounding Percent: {drbPct:F2}%";
            }
        }
    }
}
