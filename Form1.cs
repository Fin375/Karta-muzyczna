using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using System.Runtime.InteropServices;
using System.IO;

namespace UPLAB1
{
    public partial class Form1 : Form
    {
        private SoundPlayer player1;
        private WindowsMediaPlayer player2;
        private bool isPlaying = false;

        public Form1()
        {
            InitializeComponent();
            player1 = new SoundPlayer();
            player2 = new WindowsMediaPlayer();
        }

        
       /* public struct WaveHeader
        {
            public byte[] riffID;
            public uint size;
            public byte[] wavID;
            public byte[] fmtID;
            public uint fmtSize;
            public ushort format;
            public ushort channels;
            public uint sampleRate;
            public uint bytePerSec;
            public ushort blockSize;
            public ushort bit;
            public byte[] dataID;
            public uint dataSize;

            public override string ToString()
            {
                return "riffID: " + riffID + "\n" +
                    "size: " + size + "\n" +
                    "fmtSize: " + fmtSize + "\n" +
                    "dataSize: " + dataSize + "\n" +
                    "sampleRate: " + sampleRate + "\n" +
                    "channel: " + channels;
            }
        }*/
        public struct WAVEHDR
        {
            public IntPtr lpData;
            public uint dwBufferLength;
            public uint dwBytesRecorded;
            public IntPtr dwUser;
            public uint dwFlags;
            public uint dwLoops;
            public IntPtr lpNext;
            public IntPtr reserved;
        }

        [DllImport("winmm.dll")]
        public static extern int waveOutWrite(IntPtr hwo, ref WAVEHDR pwh, uint cbwh);

        public WAVEHDR waveHeader;



        private void FileNameButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki muzyczne|*.wav";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string plik = openFileDialog1.FileName;
                FileNameLabel.Text = plik;

                player1.SoundLocation = plik;
                player2.URL = plik;

               // player1.Stop();
                player2.controls.stop();
            }
        }

        private void StartButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(player1.SoundLocation))
            {
                player1.Play();
                isPlaying = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isPlaying == true)
            {
                player1.Stop();
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(player2.URL))
            {
                player2.controls.play();
            }
        }

        private void StopButton2_Click(object sender, EventArgs e)
        {
            if (player2.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                player2.controls.stop();
            }
        }

        private void StartButton3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(player1.SoundLocation))
            {
                IntPtr hWaveOut = IntPtr.Zero; // Uzyskaj uchwyt urządzenia audio

                // Wczytaj plik jako tablicę bajtów
                byte[] audioData = File.ReadAllBytes(player1.SoundLocation);

                // Ustaw dane nagłówka WAV
                waveHeader.lpData = Marshal.UnsafeAddrOfPinnedArrayElement(audioData, 0);
                waveHeader.dwBufferLength = (uint)audioData.Length;

                // Wyślij dane do urządzenia audio
                int result = waveOutWrite(hWaveOut, ref waveHeader, (uint)Marshal.SizeOf(waveHeader));

                if (result != 0)
                {
                    MessageBox.Show("Błąd podczas odtwarzania pliku WAV." + result.ToString());
                }
               
            }
        }


        
    }
}
