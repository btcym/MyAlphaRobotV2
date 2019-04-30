﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAlphaRobot
{
    public static class CONST
    {
        public static int DEFAULT_TRY_COUNT = 3;

        public static class DISTRIBUTION
        {

            public static class FIRMWARE
            {
                public static class RELEASE
                {
                    public static string VERSION = "https://raw.githubusercontent.com/Super169/RobotControl.Distribution/master/release";
                    public static string PATH = "https://github.com/Super169/RobotControl.Distribution/raw/master/Firmware/release/";
                }
                public static class BETA
                {
                    public static string VERSION = "https://raw.githubusercontent.com/Super169/RobotControl.Distribution/master/beta";
                    public static string PATH = "https://github.com/Super169/RobotControl.Distribution/raw/master/Firmware/beta/";
                }
                public static class HAILZD
                {
                    public static string VERSION = "https://raw.githubusercontent.com/Super169/RobotControl.Distribution/master/hailzd";
                    public static string PATH = "https://github.com/Super169/RobotControl.Distribution/raw/master/Firmware/hailzd/";
                }
            }
        }

        public static string CONFIG_FOLDER = "config";
        public static string SYSTEM_CONFIG = "system.json";
        public static bool SYSTEM_CONFIG_ZIP = false;

        public static class DEFAULT_CONFIG
        {
            public static string ROBOT_CONFIG_FILE = "robot.jaz";
            public static string BLOCKLY_PATH = "Blockly";
            public static bool AUTO_CHECK_VERSION = false;
            public static bool AUTO_CHECK_FIRMWARE = false;
            public static byte WAIT_REBOOT_SEC = 15;
            public static bool DISABLE_BATTERY_UPDATE = false;
            public static bool DISABLE_MPU_UPDATE = false;
            public static bool DEVEOPER_MODE = false;
        }
        public static string ROBOT_CONFIG_FILTER = "Robot Config|*.jaz";
        public static string ROBOT_ACTION_FILTER = "Robot Action|*.myAct";
        public static string ROBOT_CSV_FILTER = "Robot CSV|*.csv";
        public static string IMAGE_FILTER = "JPG, PNG|*.jpg, *.png|AL (*.*)|*.*";

        public static int MAX_SERVO = 32;
        public static int MAX_ROBOT_SERVO = 32;
        public const int SERVO_SIZE = 38;
        public const int SERVO_TIME_FACTOR = 20;  // 20 or 25??

        public static class COMMAND
        {
            public const string StartSystemWork = "StartSystemWork";
            public const string EndSystemWork = "EndSystemWork";

        }

        public static class SERVO_TYPE
        {
            public const byte UBT = 1;
            public const byte HaiLzd = 2;
        }

        public enum UBT_FILE
        {
            AESX, HTS, UNKNOWN
        }

        // Combo Information
        public static class CI
        {
            public const int MAX_COMBO = 10;
            public const int MAX_COMBO_SIZE = 20;
            public const int COMBO_SIZE = 2;
            public static class OFFSET
            {
                public const int ID = 4;
                public const int COMBO_DATA = 10;
            }
        }

        // Action Information
        public static class AI
        {
            public const int MAX_ACTION = 250;
            public const int MAX_POSES = 65535;
            public const int ACTION_SIZE = HEADER.SIZE + MAX_POSES * POSE.SIZE;

            public const byte STOP_MUSIC_VOL = 0xFE;

            public const byte FULL_DATA_OFFSET = 8;

            public static class HEADER
            {
                public const int SIZE = 60;
                public static class OFFSET
                {
                    public const int ID = 4;
                    public const int NAME = 6;
                    public const int NAME_LEN = 27;
                    public const int POSE_CNT_LOW = 28;
                    public const int POSE_CNT_HIGH = 29;
                    public const int EXECUTE_TIME = 30;
                    public const int AFFECT_SERVO = 34;
                    public const int CHECKSUM = 58;
                }
            }
            public static class POSE
            {
                public const int SIZE = 60;
                public static class OFFSET
                {
                    public const int ID = 4;
                    public const int SEQ_LOW = 5;
                    public const int SEQ_HIGH = 55;
                    public const int ENABLE = 6;
                    public const int EXECUTE_TIME = 7;
                    public const int WAIT_TIME = 9;
                    public const int ANGLE_ID = 10;    // ID starting from 1, to simplify the operation, use position - 1
                    public const int SERVO_ANGLE = 11;
                    public const int SERVO_LED = 43;
                    public const int HEAD_LED = 51;
                    public const int MP3_FOLDER = 52;
                    public const int MP3_FILE = 53;
                    public const int MP3_VOL = 54;
                    public const int CHECKSUM = 58;
                }
            }
        }

        // Event Header
        public static class EH
        {
            public const int HEADER_SIZE = 16;
            public static class OFFSET
            {
                public const int MODE = 4;
                public const int VERSION = 5;
                public const int COUNT = 6;
                public const int ACTION = 7;
            }
        }

        // Event Data
        public static class ED
        {
            public const int BATCH_SIZE = 8;
            public const int EVENT_SIZE = 12;
            public static class OFFSET
            {
                public const int MODE = 4;
                public const int START_IDX = 5;
                public const int COUNT = 6;
                public const int DATA = 16;
            }
        }

        public static class V1CMD
        {
            public const char GET_ANGLE = 'A';
            public const char DEBUG_ENBLE = 'B';
            public const char DEBUG_DISABLE = 'b';
            public const char DOWNLOAD = 'D';
            public const char UPLOAD = 'U';
            public const char READ_SPIFFS = 'R';
            public const char WRITE_SPIFFS = 'W';
            public const char LOCK_SERVO = 'L';
            public const char FREE_SERVO = 'F';
            public const char MOVE_SERVO = 'M';
            public const char PLAY = 'P';
            public const char DETECT_SERVO = 'T';
            public const char RESET_CONN = 'Z';
        }

        public static class AESX_FILE
        {
            public const int HEADER_SIZE = 153;
            public const int RECORD_SIZE = 216;
            public const int TAIL_SIZE = 10;
            public const int MIN_SIZE = HEADER_SIZE + RECORD_SIZE + TAIL_SIZE;
            public const byte POSE_START = 0xD4;
            public const int OFFSET_RUNTIME = 12;
            public const int OFFSET_ALLTIME = 16;
            public const int OFFSET_ANGLE = 92;
            public const int MAX_SERVO = 16;
            public const int SERVO_SIZE = 8;

            public const int MS_PER_TIME = 20;

        }

        public static class HTS_FILE
        {
            public const int HEADER_SIZE = 33;
            public const int RECORD_SIZE = 33;
            public const int TAIL_SIZE = 33;
            public const int MIN_SIZE = HEADER_SIZE + RECORD_SIZE + TAIL_SIZE;
            public const byte POSE_START_01 = 0xFB;
            public const byte POSE_START_02 = 0xBF;
            public const byte POSE_END = 0xED;
            public const int MAX_SERVO = 16;  // should be 20, but the last 4 is always 0x5A, ignore them 
            public const int SERVO_SIZE = 1;
            public static class OFFSET
            {
                public const int POSE_ID = 6;
                public const int SERVO_ANGLE = 8;
                public const int SERVO_TIME = 28;
                public const int WAIT_TIME = 29;

            }
        }

        public static class SERVO
        {
            public const int MAX_ANGLE = 240;
        }

        public static class LED
        {
            public const byte NO_CHANGE = 0b00;
            public const byte TURN_ON = 0b10;
            public const byte TURN_OFF = 0b11;
        }

        // V2 command set
        public static class CMD
        {
            public const byte RESET = 0x01;
            public const byte DEBUG = 0x02;
            public const byte DEVMODE = 0x03;
            public const byte GET_CONFIG = 0x04;
            public const byte SET_CONFIG = 0x05;
            public const byte DEFAULT_CONFIG = 0x06;
            public const byte USB_TTL_MODE = 0x07;
            public const byte GET_EH_MODE = 0x08;
            public const byte SET_EH_MODE = 0x09;
            public const byte ENABLE = 0x0A;
            public const byte CHECKBATTERY = 0x0B;
            public const byte GETNETWORK = 0x0C;
            public const byte GET_NETWORK_CONFIG = 0x0D;
            public const byte SET_NETWORK_CONFIG = 0x0E;
            public const byte SERVOTYPE = 0x10;
            public const byte SERVOANGLE = 0x11;
            public const byte ONEANGLE = 0x12;
            public const byte SERVOADJANGLE = 0x13;
            public const byte ONEADJANGLE = 0x14;
            public const byte SETADJANGLE = 0x15;
            public const byte SERVOCOMMAND = 0x16;
            public const byte SET_ANGLE = 0x18;
            public const byte LOCKSERVO = 0x21;
            public const byte UNLOCKSERVO = 0x22;
            public const byte SERVOMOVE = 0x23;
            public const byte LED = 0x24;
            public const byte HEAD_LED = 0x31;
            public const byte PLAYACTION = 0x41;
            public const byte STOPACTION = 0x4F;

            public const byte GET_EVENT_HEADER = 0x91;
            public const byte GET_EVENT_DATA = 0x92;
            public const byte WRITE_EVENT_HEADER = 0x93;
            public const byte WRITE_EVENT_DATA = 0x94;



            public static class MP3
            {
                public const byte Stop = 0x32;
                public const byte PlayFile = 0x33;
                public const byte PlayMP3 = 0x34;
                public const byte PlayAdvert = 0x35;
                public const byte SetVol = 0x36;
            }
            public const byte GET_ADLIST = 0x60;
            public const byte GET_ADLIST_RETURN = 38;

            public const byte GET_ADHEADER = 0x61;
            public const byte GET_ADPOSE = 0x62;
            // public const byte GET_ADDATA = 0x63;

            public const byte GET_COMBO = 0x68;
            public const byte UPD_COMBO = 0x69;


            public const byte UPD_ADHEADER = 0x71;
            public const byte UPD_ADPOSE = 0x72;
            public const byte UPD_ADNAME = 0x74;
            public const byte DEL_ACTION = 0x75;
            // public const byte READSPIFFS = 0xF1;
            // public const byte WRITESPIFFS = 0xF2;


            public const byte GET_VERSION = 0xFF;

            /*
            public static class RETURN_LEN
            {
                public const byte GET_VERSION = 6;
                public const byte GET_CONFIG = 56;
                public const byte GET_NETWORK_CONFIG = 116;
                public const byte GET_COMBO = 56;
                public const byte GET_ADPOSE = 56;
                public const byte GET_ADLIST = 34;
            }
            
            public static class RETURN_SIZE
            {
                public const byte SINGLE_RETURN = 7;
                public const byte UBT_REURN = 10;
                public const byte GET_VERSION = 10;
                public const byte SERVOANGLE = 38;
                public const byte GET_CONFIG = 60;
                public const byte GET_NETWORK_CONFIG = 120;
                public const byte GET_COMBO = 60;
                public const byte GET_ADPOSE = 60;
                public const byte GET_ADLIST = 38;
                public const byte CHECKBATTERY = 9;
            }
            */
        }

        public static class CB
        {
            public const byte SINGLE_RETURN_SIZE = 7;

            public class CMD_INFO
            {
                public byte code;
                public Int16 minBytes;
                // TODO: should we have minBytes and expectBytes 
                //       In some situation, minBytes is returned for error
                // If minBytes = -1, it must call SendRobotCommand with expectCnt
                // Syntax: bool SendRobotCommand(byte[] cmd, CONST.CB.CMD_INFO info, uint expectCnt)

                public byte dataLen;
                // TODO: study if any situation then dataLen != Count - 4

                public long maxMs;



                public CMD_INFO(byte code, Int16 minBytes, byte dataLen, long maxMs)
                {
                    this.code = code;
                    this.minBytes = minBytes;
                    this.dataLen = dataLen;
                    this.maxMs = maxMs;
                }
            }

            public static CMD_INFO RESET = new CMD_INFO(0x01, 7, 3, 0);
            public static CMD_INFO DEBUG = new CMD_INFO(0x02, 7, 3, 0);
            public static CMD_INFO DEVMODE = new CMD_INFO(0x03, 7, 3, 0);
            public static CMD_INFO GETCONFIG = new CMD_INFO(0x04, 60, 56, 1000);
            public static CMD_INFO SETCONFIG = new CMD_INFO(0x05, 7, 3, 0);
            public static CMD_INFO DEFAULTCONFIG = new CMD_INFO(0x06, 7, 3, 0);
            public static CMD_INFO GET_EH_MODE = new CMD_INFO(0x08, 7, 3, 0);
            public static CMD_INFO SET_EH_MODE = new CMD_INFO(0x09, 7, 3, 0);
            public static CMD_INFO ENABLE = new CMD_INFO(0x0A, 11, 7, 0);
            public static CMD_INFO CHECK_BATTERY = new CMD_INFO(0x0B, 9, 5, 1000);
            public static CMD_INFO GET_NETWORK = new CMD_INFO(0x0C, 60, 56, 0);
            public static CMD_INFO GET_WIFI_CONFIG = new CMD_INFO(0x0D, 120, 116, 1000);
            public static CMD_INFO SET_WIFI_CONFIG = new CMD_INFO(0x0E, 7, 3, 0);
            public static CMD_INFO PARTIAL_CONFIG = new CMD_INFO(0x0F, 7, 3, 0);
            public static CMD_INFO SERVOTYPE = new CMD_INFO(0x10, 7, 3, 1000);
            public static CMD_INFO SERVOANGLE = new CMD_INFO(0x11, 38, 34, 1000);
            public static CMD_INFO ONEANGLE = new CMD_INFO(0x12, 9, 5, 0);
            public static CMD_INFO SERVOADJANGLE = new CMD_INFO(0x13, 38, 34, 0);
            public static CMD_INFO ONEADJANGLE = new CMD_INFO(0x14, 9, 5, 0);
            public static CMD_INFO SETADJANGLE = new CMD_INFO(0x15, 7, 3, 0);
            public static CMD_INFO SERVOCMD = new CMD_INFO(0x16, 0, 0, 2000);
            public static CMD_INFO SETANGLE = new CMD_INFO(0x18, 7, 3, 2000);
            public static CMD_INFO LOCKSERVO = new CMD_INFO(0x21, -1, 0, 0);
            public static CMD_INFO UNLOCKSERVO = new CMD_INFO(0x22, -1, 0, 0);
            public static CMD_INFO SERVOMOVE = new CMD_INFO(0x23, -1, 0, 0);
            public static CMD_INFO LED = new CMD_INFO(0x24, 7, 3, 0);
            public static CMD_INFO SET_HEADLED = new CMD_INFO(0x31, 7, 3, 0);
            public static CMD_INFO MP3_STOP = new CMD_INFO(0x32, 7, 3, 0);
            public static CMD_INFO MP3_PLAYFILE = new CMD_INFO(0x33, 7, 3, 0);
            public static CMD_INFO MP3_PLAYMP3 = new CMD_INFO(0x34, 7, 3, 0);
            public static CMD_INFO MP3_PLAYADVERT = new CMD_INFO(0x35, 7, 3, 0);
            public static CMD_INFO MP3_SETVOLUME = new CMD_INFO(0x36, 7, 3, 0);
            public static CMD_INFO PLAYACTION = new CMD_INFO(0x41, 7, 3, 0);
            public static CMD_INFO PLAYCOMBO = new CMD_INFO(0x42, 7, 3, 0);
            public static CMD_INFO STOPPLAY = new CMD_INFO(0x4F, 7, 3, 0);
            public static CMD_INFO GET_ADLIST = new CMD_INFO(0x60, 38, 34, 0);
            public static CMD_INFO GET_ADHEADER = new CMD_INFO(0x61, 60, 56, 1000);
            public static CMD_INFO GET_ADPOSE = new CMD_INFO(0x62, 60, 56, 1000);
            public static CMD_INFO GET_COMBO = new CMD_INFO(0x68, 60, 56, 1000);
            public static CMD_INFO UPD_COMBO = new CMD_INFO(0x69, 7, 3, 0);
            public static CMD_INFO UPD_ADHEADER = new CMD_INFO(0x71, 7, 3, 0);
            public static CMD_INFO UPD_ADPOSE = new CMD_INFO(0x72, 7, 3, 1000);
            public static CMD_INFO UPD_ADNAME = new CMD_INFO(0x74, 7, 3, 0);
            public static CMD_INFO DEL_ACTION = new CMD_INFO(0x75, 7, 3, 1000);
            public static CMD_INFO CHK_MPU = new CMD_INFO(0x81, 7, 3, 1000);
            public static CMD_INFO GET_MPU_DATA = new CMD_INFO(0x82, 20, 14, 1000);
            public static CMD_INFO GET_VERSION = new CMD_INFO(0xFF, 10, 6, 0);

            public static CMD_INFO GET_EVENT_HEADER = new CMD_INFO(0x91, 16, 12, 5000);
            public static CMD_INFO GET_EVENT_DATA = new CMD_INFO(0x92, 128, 124, 5000);

            public static CMD_INFO SAVE_EVENT_HEADER = new CMD_INFO(0x93, 7, 3, 5000);
            public static CMD_INFO SAVE_EVENT_DATA = new CMD_INFO(0x94, 7, 3, 5000);


        }

        public static class BLOCKLY
        {
            public static string CHECK_FILE = "blockly_compressed.js";
            public static string RESOURCE = "_www";
            public static string HTML = "EventBuilder.html";
            public static string CUSTOM_BLOCKS = "custom_blocks.js";
            public static string TOOLBOX = "toolbox.xml";
            public static string WORKSPCE = "workspace.xml";
            public static string EVENT_FILE_FILTER = "Robot Events|*.myEvt";
            public static string DEFAULT_EVENT_FILE = "RobotEvents.myEvt";

        }


    }
}
