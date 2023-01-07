using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AssettoCorsaSharedMemory
{
    public class StaticInfoEventArgs : EventArgs
    {
        public StaticInfoEventArgs (StaticInfo staticInfo)
        {
            this.StaticInfo = staticInfo;
        }

        public StaticInfo StaticInfo { get; private set; }
    }

    [StructLayout (LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    [Serializable]
    public struct StaticInfo
    {
        /// <summary>
        /// Version of the Shared Memory structure
        /// </summary>
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String SMVersion;

        /// <summary>
        /// Version of Assetto Corsa
        /// </summary>
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String ACVersion;

        // session static info

        /// <summary>
        /// Number of sessions in this instance
        /// </summary>
        public int NumberOfSessions;

        /// <summary>
        /// Max number of possible cars on track
        /// </summary>
        public int NumCars;

        /// <summary>
        /// Name of the player’s car
        /// see ACCSharedMemoryDocumentation Appendix 2
        /// </summary>
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String CarModel;

        /// <summary>
        /// Name of the track
        /// </summary>
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String Track;

        /// <summary>
        /// Name of the player
        /// </summary>
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String PlayerName;

        /// <summary>
        /// Surname of the player
        /// </summary>
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String PlayerSurname;

        /// <summary>
        /// Nickname of the player
        /// </summary>
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String PlayerNick;

        /// <summary>
        /// Number of track sectors
        /// </summary>
        public int SectorCount;

        // car static info

        /// <summary>
        /// Max torque value of the player’s car
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public float MaxTorque;

        /// <summary>
        /// Max power value of the player’s car
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public float MaxPower;

        /// <summary>
        /// Maximum rpm
        /// </summary>
        public int MaxRpm;

        /// <summary>
        /// Maximum fuel tank capacity
        /// </summary>
        public float MaxFuel;

        /// <summary>
        /// Max travel distance of each tyre [FL, FR, RL, RR]
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] SuspensionMaxTravel;

        /// <summary>
        /// Radius of each tyre [FL, FR, RL, RR]
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreRadius;

        // since 1.5

        /// <summary>
        /// Max turbo boost value of the player’s car
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public float MaxTurboBoost;

        [Obsolete("AirTemp since 1.6 in physic")]
        public float Deprecated1;

        [Obsolete("RoadTemp since 1.6 in physic")]
        public float Deprecated2;

        /// <summary>
        /// Cut penalties enabled: 1 (true) or 0 (false)
        /// </summary>
        public int PenaltiesEnabled;

        /// <summary>
        /// Fuel consumption rate: 0 (no cons), 1 (normal), 2 (double cons)
        /// </summary>
        public float AidFuelRate;

        /// <summary>
        /// Tire wear rate: 0 (no wear), 1 (normal), 2 (double wear) etc.
        /// </summary>
        public float AidTireRate;

        /// <summary>
        /// Damage rate: 0 (no damage) to 1 (normal)
        /// </summary>
        public float AidMechanicalDamage;

        /// <summary>
        /// Player starts with hot (optimal temp) tyres: 1 (true) or 0 (false)
        /// </summary>
        public int AidAllowTyreBlankets;

        /// <summary>
        /// Stability control used
        /// </summary>
        public float AidStability;

        /// <summary>
        /// Auto clutch used
        /// </summary>
        public int AidAutoClutch;

        /// <summary>
        /// If player’s car has the “auto blip” feature enabled : 0 or 1
        /// </summary>
        public int AidAutoBlip;

        // since 1.7.1

        /// <summary>
        /// If player’s car has the “DRS” system: 0 or 1
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public int HasDRS;

        /// <summary>
        /// If player’s car has the “ERS” system: 0 or 1
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public int HasERS;

        /// <summary>
        /// If player’s car has the “KERS” system: 0 or 1
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public int HasKERS;

        /// <summary>
        /// Max KERS Joule value of the player’s car
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public float KersMaxJoules;

        /// <summary>
        /// Count of possible engine brake settings of the player’s car
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public int EngineBrakeSettingsCount;

        /// <summary>
        /// Count of the possible power controllers of the player’s car
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public int ErsPowerControllerCount;

        // since 1.7.2

        /// <summary>
        /// Length of the spline of the selected track
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public float TrackSplineLength;

        /// <summary>
        /// Name of the track’s layout (only multi-layout tracks)
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public string TrackConfiguration;

        // since 1.10.2

        /// <summary>
        /// Max ERS Joule value of the player’s car
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public float ErsMaxJ;

        // since 1.13

        /// <summary>
        /// 1 if the race is a timed one
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public int IsTimedRace;

        /// <summary>
        /// 1 if the timed race is set with an extra lap
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public int HasExtraLap;

        /// <summary>
        /// Name of the used skin
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String CarSkin;

        /// <summary>
        /// How many positions are going to be swapped in the second race
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public int ReversedGridPositions;

        /// <summary>
        /// Pit window opening time
        /// </summary>
        public int PitWindowStart;

        /// <summary>
        /// Pit windows closing time
        /// </summary>
        public int PitWindowEnd;

        //Since ???

        /// <summary>
        /// If is a multiplayer session
        /// </summary>
        public int IsOnline;

        /// <summary>
        /// Name of the dry tyres
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public String DryTyresName;

        /// <summary>
        /// Name of the wet tyres
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public String WetTyresName;
    }
}
