using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AssettoCorsaSharedMemory
{
    public class PhysicsEventArgs : EventArgs
    {
        public PhysicsEventArgs (Physics physics)
        {
            this.Physics = physics;
        }

        public Physics Physics { get; private set; }
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct Coordinates
    {
        public float X;
        public float Y;
        public float Z;
    }

    [StructLayout (LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    [Serializable]
    public struct Physics
    {
        /// <summary>
        /// Current step index
        /// </summary>
        public int PacketId;

        /// <summary>
        /// Gas pedal input value (from -0 to 1.0)
        /// </summary>
        public float Gas;

        /// <summary>
        /// Brake pedal input value (from -0 to 1.0)
        /// </summary>
        public float Brake;

        /// <summary>
        /// Amount of fuel remaining in kg
        /// </summary>
        public float Fuel;

        /// <summary>
        /// Current gear
        /// </summary>
        public int Gear;

        /// <summary>
        /// Engine revolutions per minute
        /// </summary>
        public int Rpms;

        /// <summary>
        /// Steering input value (from -1.0 to 1.0)
        /// </summary>
        public float SteerAngle;

        /// <summary>
        /// Car speed in km/h
        /// </summary>
        public float SpeedKmh;

        /// <summary>
        /// Car velocity vector in global coordinates
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] Velocity;

        /// <summary>
        /// Car acceleration vector in global coordinates
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] AccG;

        /// <summary>
        /// Tyre slip for each tyre [FL, FR, RL, RR]
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] WheelSlip;

        /// <summary>
        /// Wheel load for each tyre [FL, FR, RL, RR]
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] WheelLoad;

        /// <summary>
        /// Tyre pressure [FL, FR, RL, RR]
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] WheelsPressure;

        /// <summary>
        /// Wheel angular speed in rad/s [FL, FR, RL, RR]
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] WheelAngularSpeed;

        /// <summary>
        /// Tyre wear [FL, FR, RL, RR]
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreWear;

        /// <summary>
        /// Dirt accumulated on tyre surface [FL, FR, RL, RR]
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreDirtyLevel;

        /// <summary>
        /// Tyre rubber core temperature [FL, FR, RL, RR]
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreCoreTemperature;

        /// <summary>
        /// Wheels camber in radians [FL, FR, RL, RR]
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] CamberRad;

        /// <summary>
        /// Suspension travel [FL, FR, RL, RR]
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] SuspensionTravel;

        /// <summary>
        /// DRS on
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public float Drs;

        /// <summary>
        /// TC in action
        /// </summary>
        public float TC;

        /// <summary>
        /// Car yaw orientation
        /// </summary>
        public float Heading;

        /// <summary>
        /// Car pitch orientation
        /// </summary>
        public float Pitch;

        /// <summary>
        /// Car roll orientation
        /// </summary>
        public float Roll;

        /// <summary>
        /// Centre of gravity height
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public float CgHeight;

        /// <summary>
        /// Car damage: front 0, rear 1, left 2, right 3, centre 4
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 5)]
        public float[] CarDamage;

        /// <summary>
        /// Number of tyres out of track
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public int NumberOfTyresOut;

        /// <summary>
        /// Pit limiter is on
        /// </summary>
        public int PitLimiterOn;

        /// <summary>
        /// ABS in action
        /// </summary>
        public float Abs;

        /// <summary>
        /// KERS/ERS battery charge: 0 to 1
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public float KersCharge;

        /// <summary>
        /// KERS/ERS input to engine: 0 to 1
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public float KersInput;

        /// <summary>
        /// Automatic transmission on
        /// </summary>
        public int AutoShifterOn;

        /// <summary>
        /// Ride height: 0 front, 1 rear
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] RideHeight;

        // since 1.5

        /// <summary>
        /// Car turbo level
        /// </summary>
        public float TurboBoost;

        /// <summary>
        /// Car ballast in kg
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public float Ballast;

        /// <summary>
        /// Air density
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public float AirDensity;

        // since 1.6

        /// <summary>
        /// Air temperature
        /// </summary>
        public float AirTemp;

        /// <summary>
        /// Road temperature
        /// </summary>
        public float RoadTemp;

        /// <summary>
        /// Car angular velocity vector in local coordinates
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] LocalAngularVelocity;

        /// <summary>
        /// Force feedback signal
        /// </summary>
        public float FinalFF;

        // since 1.7

        /// <summary>
        /// Performance meter compared to the best lap
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public float PerformanceMeter;

        /// <summary>
        /// Engine brake setting
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public int EngineBrake;

        /// <summary>
        /// ERS recovery level
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public int ErsRecoveryLevel;

        /// <summary>
        /// ERS selected power controller
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public int ErsPowerLevel;

        /// <summary>
        /// ERS changing: 0 (Motor) or 1 (Battery)
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public int ErsHeatCharging;

        /// <summary>
        /// If ERS battery is recharging: 0 (false) or 1 (true)
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public int ErsisCharging;

        /// <summary>
        /// KERS/ERS KiloJoule spent during the lap
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public float KersCurrentKJ;

        /// <summary>
        /// If DRS is available (DRS zone): 0 (false) or 1 (true)
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public int DrsAvailable;

        /// <summary>
        /// If DRS is enabled: 0 (false) or 1 (true)
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public int DrsEnabled;

        /// <summary>
        /// Brake discs temperatures
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] BrakeTemp;

        // since 1.10

        /// <summary>
        /// Clutch pedal input value (from -0 to 1.0)
        /// </summary>
        public float Clutch;

        /// <summary>
        /// Inner temperature of each tyre [FL, FR, RL, RR]
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreTempI;

        /// <summary>
        /// Middle temperature of each tyre [FL, FR, RL, RR]
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreTempM;

        /// <summary>
        /// Outer temperature of each tyre [FL, FR, RL, RR]
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreTempO;

        // since 1.10.2

        /// <summary>
        /// Car is controlled by the AI
        /// </summary>
        public int IsAIControlled;

        // since 1.11

        /// <summary>
        /// Tyre contact point global coordinates [FL, FR, RL, RR]
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public Coordinates[] TyreContactPoint;

        /// <summary>
        /// Tyre contact normal [FL, FR, RL, RR] [x,y,z]
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public Coordinates[] TyreContactNormal;

        /// <summary>
        /// Tyre contact heading [FL, FR, RL, RR] [x,y,z]
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public Coordinates[] TyreContactHeading;

        /// <summary>
        /// Front brake bias
        /// see ACCSharedMemoryDocumentation Appendix 4
        /// </summary>
        public float BrakeBias;

        // since 1.12

        /// <summary>
        /// Car velocity vector in local coordinates
        /// </summary>
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] LocalVelocity;

        // since ???
        
        /// <summary>
        /// Not shown in ACC
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public int P2PActivation;

        /// <summary>
        /// Not shown in ACC
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public int P2PStatus;
        
        /// <summary>
        /// Maximum engine rpm
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public float CurrentMaxRPM;
        
        /// <summary>
        /// Not shown in ACC
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] MZ;
        
        /// <summary>
        /// Not shown in ACC
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] FX;

        /// <summary>
        /// Not shown in ACC
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] FY;

        /// <summary>
        /// Tyre slip ratio [FL, FR, RL, RR] in radians
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] SlipRatio;
        
        /// <summary>
        /// Tyre slip angle [FL, FR, RL, RR]
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] SlipAngle;

        /// <summary>
        /// TC in action
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public int TCInAction;

        /// <summary>
        /// ABS in action
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        public int ABSInAction;

        /// <summary>
        /// Suspensions damage levels [FL, FR, RL, RR]
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] SuspensionDamage;
        
        /// <summary>
        /// Tyres core temperatures [FL, FR, RL, RR]
        /// <para>
        /// NOT AVAILABLE IN ACC
        /// </para>
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreTemp;

        /// <summary>
        /// Water Temperature
        /// </summary>
        public float WaterTemp;

        /// <summary>
        /// Brake pressure [FL, FR, RL, RR] 
        /// see ACCSharedMemoryDocumentation Appendix 2
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] BrakePressure;

        /// <summary>
        /// Brake pad compund front
        /// </summary>
        public int FrontBrakeCompound;

        /// <summary>
        /// Brake pad compund rear
        /// </summary>
        public int RearBrakeCompound;

        /// <summary>
        /// Brake pad wear [FL, FR, RL, RR]
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] PadLife;

        /// <summary>
        /// Brake disk wear [FL, FR, RL, RR]
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] DiscLife;

        /// <summary>
        /// Ignition switch set to on?
        /// </summary>
        public int IgnitionOn;

        /// <summary>
        /// Starter Switch set to on?
        /// </summary>
        public int StarterEngineOn;

        /// <summary>
        /// Engine running?
        /// </summary>
        public int IsEngineRunning;

        /// <summary>
        /// Vibrations sent to the FFB, could be used for motion rigs
        /// </summary>
        public float KerbVibration;

        /// <summary>
        /// Vibrations sent to the FFB, could be used for motion rigs
        /// </summary>
        public float SlipVibrations;

        /// <summary>
        /// Vibrations sent to the FFB, could be used for motion rigs
        /// </summary>
        public float GVibrations;

        /// <summary>
        /// Vibrations sent to the FFB, could be used for motion rigs
        /// </summary>
        public float ABSVibrations;

        
    }
}
