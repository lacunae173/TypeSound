using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SFML.Audio;

namespace TypeSound
{
    static class Program
    {
        private static Form1 form;
        public static Sounds sounds = new Sounds();

        private static bool ctrlDown = false;
        private static bool altDown = false;
        private static bool deleteDown = false;

        private static bool continueSoundPlaying = false;
        private static Dictionary<Keys, Timer> keyTimers = new Dictionary<Keys, Timer>();
        private static List<Keys> continueKeys = new List<Keys>();

        private static void kbh_OnKeyPressed(object sender, Keys e)
        {
            if (continueKeys.Contains(e))
            {
                return;
            }
            if (e == Keys.LControlKey || e == Keys.RControlKey)
                ctrlDown = true;
            if (e == Keys.LMenu || e == Keys.RMenu)
                altDown = true;
            if (e == Keys.Delete)
                deleteDown = true;
            if (ctrlDown && altDown && deleteDown)
            {
                kbh_OnKeyUnPressed(null, Keys.LControlKey);
                kbh_OnKeyUnPressed(null, Keys.RControlKey);
                kbh_OnKeyUnPressed(null, Keys.LMenu);
                kbh_OnKeyUnPressed(null, Keys.RMenu);
                kbh_OnKeyUnPressed(null, Keys.Delete);
            } 
            else
            {
                keyTimers[e].Tick += (sd, ev) => TimerEventProcessor(sender, ev, e);
                keyTimers[e].Start();
            }
            
            if (ctrlDown && e == Keys.C)
            {
                sounds.soundDict[Sounds.copyCode].Play();
                return;
            }
            if (ctrlDown && e == Keys.V)
            {
                sounds.soundDict[Sounds.pasteCode].Play();
                return;
            }
            

            Sound sound = sounds.soundDict[(int)e];
            if (sound.SoundBuffer != null)
            {
                sound.Play();
                return;
            }
            sounds.normalTypeSound.Play();
        }

        private static void TimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs, Keys k)
        {
            Timer timer = keyTimers[k];
            timer.Stop();
            continueKeys.Add(k);
            if (!continueSoundPlaying)
            {
                sounds.continueSound.Loop = true;
                sounds.continueSound.Play();
                continueSoundPlaying = true;
            }
        }

        private static void kbh_OnKeyUnPressed(object sender, Keys e)
        {
            continueKeys.RemoveAll((k) => k == e);
            keyTimers[e].Stop();

            if (e == Keys.LControlKey || e == Keys.RControlKey)
                ctrlDown = false;
            if (e == Keys.LMenu || e == Keys.RMenu)
                altDown = false;
            if (e == Keys.Delete)
                deleteDown = false;

            if (continueSoundPlaying && continueKeys.Count == 0)
            {
                sounds.continueSound.Stop();
                continueSoundPlaying = false;
            }
        }
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            foreach (Keys k in Enum.GetValues(typeof(Keys)))
            {
                Timer timer = new Timer();
                timer.Interval = 500;
                keyTimers[k] = timer;
            }

            LowLevelKeyboardHook kbh = new LowLevelKeyboardHook();
            kbh.OnKeyPressed += kbh_OnKeyPressed;   
            kbh.OnKeyUnpressed += kbh_OnKeyUnPressed;
            kbh.HookKeyboard();

            form = new Form1();
            Application.Run(form);
            

            kbh.UnHookKeyboard();

        }
    }
}
