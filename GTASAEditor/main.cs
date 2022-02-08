using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libdebug;

namespace GTASA_Handling_Editor
{
    public partial class main : Form
    {
        private PS4DBG ps4;
        public int currentPID;
        public ulong handlingAddr = 0x6D39CB4;
        public bool isReady;
        public main()
        {
            InitializeComponent();
        }
        enum Chandling
        {
            index = 0x0,
            fMass = 0x4,
            padding_0 = 0x8,
            fTurnMass = 0xc,
            fDragMult = 0x10,
            centreOfMassX = 0x14,
            centreOfMassY = 0x18,
            centreOfMassZ = 0x1c,
            nPercentSubmerged = 0x20,
            padding_1 = 0x24,
            fTractionMultiplier = 0x28,
            fTractionLoss = 0xA4,
            fTractionBias = 0xA8,
            fEngineInertia = 0x80,
            fSeatOffsetDistance = 0xC8,
            fSteeringLock = 0xA0,
            fSuspensionForceLevel = 0xAC,
            fSuspensionDampingLevel = 0xB0,
            fSuspensionHighSpdComDamp = 0xB4,
            fsuspensionUpperLimit = 0xB8,
            fsuspensionLowerLimit = 0xBC,
            fsuspensionBiasBetweenFrontAndRear = 0xC0,
            fsuspensionAntiDiveMultiplier = 0xC4,
            fSpeed = 0x7C,
        };
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        void setDriftHandling(int carIndex)
        {
            Byte[] v_fmass = BitConverter.GetBytes(999f);
            Byte[] v_fTurnMass = BitConverter.GetBytes(1200f);
            Byte[] v_fEngineInertia = BitConverter.GetBytes(50f);
            Byte[] v_fTractionBias = BitConverter.GetBytes(0.8f);
            Byte[] v_fTractionLoss = BitConverter.GetBytes(0.52f);
            Byte[] v_fTractionMultiplier = BitConverter.GetBytes(0.70f);
            this.ps4.WriteMemory(currentPID, (handlingAddr + ((ulong)(carIndex) * 0xE0 + (ulong)Chandling.fMass)), v_fmass);
            this.ps4.WriteMemory(currentPID, (handlingAddr + ((ulong)(carIndex) * 0xE0 + (ulong)Chandling.fTurnMass)), v_fTurnMass);
            this.ps4.WriteMemory(currentPID, (handlingAddr + ((ulong)(carIndex) * 0xE0 + (ulong)Chandling.fEngineInertia)), v_fEngineInertia);
            this.ps4.WriteMemory(currentPID, (handlingAddr + ((ulong)(carIndex) * 0xE0 + (ulong)Chandling.fTractionBias)), v_fTractionBias);
            this.ps4.WriteMemory(currentPID, (handlingAddr + ((ulong)(carIndex) * 0xE0 + (ulong)Chandling.fTractionLoss)), v_fTractionLoss);
            this.ps4.WriteMemory(currentPID, (handlingAddr + ((ulong)(carIndex) * 0xE0 + (ulong)Chandling.fTractionMultiplier)), v_fTractionMultiplier);
        }
        void seRCWHandling(int carIndex)
        {
            Byte[] v_fmass = BitConverter.GetBytes(500.0f);
            Byte[] v_fTurnMass = BitConverter.GetBytes(500.0f);
            this.ps4.WriteMemory(currentPID, (handlingAddr + ((ulong)(carIndex) * 0xE0 + (ulong)Chandling.fMass)), v_fmass);
            this.ps4.WriteMemory(currentPID, (handlingAddr + ((ulong)(carIndex) * 0xE0 + (ulong)Chandling.fTurnMass)), v_fTurnMass);
        }
        void setUSWHandling(int carIndex)
        {
            Byte[] vfSteeringLock = BitConverter.GetBytes(68f);
            this.ps4.WriteMemory(currentPID, (handlingAddr + ((ulong)(carIndex) * 0xE0 + (ulong)Chandling.fSteeringLock)), vfSteeringLock);
        }
        void setNeedForSpeedHandling(int carIndex)
        {
            Byte[] v_fDragMult = BitConverter.GetBytes(1f);
            Byte[] vfSpeed = BitConverter.GetBytes(5f);
            this.ps4.WriteMemory(currentPID, (handlingAddr + ((ulong)(carIndex) * 0xE0 + (ulong)Chandling.fDragMult)), v_fDragMult);
            this.ps4.WriteMemory(currentPID, (handlingAddr + ((ulong)(carIndex) * 0xE0 + (ulong)Chandling.fSpeed)), vfSpeed);
        }
        void setLoweredSusHandling(int carIndex)
        {
            Byte[] v_fsuspensionBiasBetweenFrontAndRear = BitConverter.GetBytes(0.23f);
            this.ps4.WriteMemory(currentPID, (handlingAddr + ((ulong)(carIndex) * 0xE0 + (ulong)Chandling.fsuspensionBiasBetweenFrontAndRear)), v_fsuspensionBiasBetweenFrontAndRear);
        }
        //void setRealDamageHandling(int carIndex)
        //{
        //    Byte[] v_fCollisionDamageMultiplier = BitConverter.GetBytes(20f);
        //    this.ps4.WriteMemory(currentPID, (handlingAddr + ((ulong)(carIndex) * 0xE0 + (ulong)Chandling.fCollisionDamageMultiplier)), v_fCollisionDamageMultiplier);
        //}
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            isReady = false;
            DialogResult dialogResult = DialogResult.Yes;
            if (this.ps4 != null && this.ps4.IsConnected)
                dialogResult = MessageBox.Show("You are already connected...\nWould you like to reconnect?",
                    "GTA SA Handling Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dialogResult != DialogResult.Yes)
                return;
            this.ps4 = new PS4DBG(this.textIp.Text);
            this.ps4.Connect();
            if (this.ps4 != null && this.ps4.IsConnected)
            {
                Process[] processes = this.ps4.GetProcessList().processes;
                for (int i = 0; i < processes.Length; i++)
                {
                    Process process = processes[i];
                    if (process.name == "eboot.bin")
                    {
                        currentPID = process.pid;
                        isReady = true;
                        toolStripStatusLabel2.Text = "Connected";
                        toolStripStatusLabel2.ForeColor = Color.Green;
                        this.ps4.Notify(222, "GTA SA Handling Editor Connected.");
                    }
                }
            }
        }

        private void setHandling_Click(object sender, EventArgs e)
        {
            if (isReady)
            {
                int v_handlingType = handlinglist.SelectedIndex;
                int v_carIndex = carslist.SelectedIndex - 1;
                MessageBox.Show(v_handlingType.ToString());
                if (v_handlingType == -1)
                {
                    MessageBox.Show("Please choose a handling type.");
                    return;
                }
                if (v_carIndex != 0 && v_carIndex != -1)
                {
                    switch (v_handlingType)
                    {
                        case 0:
                            setDriftHandling(v_carIndex);
                            break;
                        case 1:
                            setNeedForSpeedHandling(v_carIndex);
                            break;
                        //case 2:
                        //    setRealDamageHandling(v_carIndex);
                        //    break;
                        case 2:
                            seRCWHandling(v_carIndex);
                            break;
                        case 3:
                            setUSWHandling(v_carIndex);
                            break;
                        case 4:
                            setLoweredSusHandling(v_carIndex);
                            break;
                    }
                }
                else if (v_carIndex == -1)
                {
                    for (int i = 0; i < carslist.Items.Count - 1; i++)
                    {
                        switch (v_handlingType)
                        {
                            case 0:
                                setDriftHandling(i);
                                break;
                            case 1:
                                setNeedForSpeedHandling(i);
                                break;
                            //case 2:
                            //    setRealDamageHandling(i);
                            //    break;
                            case 2:
                                seRCWHandling(i);
                                break;
                            case 3:
                                setUSWHandling(i);
                                break;
                            case 4:
                                setLoweredSusHandling(i);
                                break;
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("You must be connected to your PS4!");
            }
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
