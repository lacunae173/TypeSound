using System;
using System.Collections.Generic;
using SFML.Audio;
using System.Windows.Forms;

namespace TypeSound
{
    
    class Sounds
    {
        public Dictionary<int, Sound> soundDict = new Dictionary<int, Sound>();
        private Dictionary<Keys, SoundBuffer> soundBuffers = new Dictionary<Keys, SoundBuffer>();
        private SoundBuffer normalTypeBuffer = new SoundBuffer(Properties.Resources.normal_type);
        private SoundBuffer copyBuffer = new SoundBuffer(Properties.Resources.ctrl_c);
        private SoundBuffer pasteBuffer = new SoundBuffer(Properties.Resources.ctrl_v);
        private SoundBuffer continueBuffer = new SoundBuffer(Properties.Resources._continue);
        private SoundBuffer altBuffer = new SoundBuffer(Properties.Resources.alt);
        public static int copyCode = -1;
        public static int pasteCode = -2;
        public static int continueCode = -3;

        public Sound normalTypeSound = new Sound();

        public Sound continueSound = new Sound();

        public static int volume = 100;

        public void SetVolume(int v)
        {
            volume = v;
            foreach(Sound s in soundDict.Values)
            {
                s.Volume = v;
            }
            normalTypeSound.Volume = v;
            continueSound.Volume = v;
        }

        public Sounds()
        {
            soundBuffers.Add(Keys.LControlKey, altBuffer);
            soundBuffers.Add(Keys.RControlKey, altBuffer);
            soundBuffers.Add(Keys.LShiftKey, altBuffer);
            soundBuffers.Add(Keys.RShiftKey, altBuffer);
            soundBuffers.Add(Keys.LMenu, altBuffer);
            soundBuffers.Add(Keys.RMenu, altBuffer);
            soundBuffers.Add(Keys.CapsLock, altBuffer);
            soundBuffers.Add(Keys.Space, new SoundBuffer(Properties.Resources.blank));
            soundBuffers.Add(Keys.Back, new SoundBuffer(Properties.Resources.backspace));
            soundBuffers.Add(Keys.Enter, new SoundBuffer(Properties.Resources.enter));
            soundBuffers.Add(Keys.LWin, new SoundBuffer(Properties.Resources.windows));
            soundBuffers.Add(Keys.Tab, new SoundBuffer(Properties.Resources.tab));
            soundBuffers.Add(Keys.Up, new SoundBuffer(Properties.Resources.up));
            soundBuffers.Add(Keys.Left, new SoundBuffer(Properties.Resources.left));
            soundBuffers.Add(Keys.Right, new SoundBuffer(Properties.Resources.right));
            soundBuffers.Add(Keys.Down, new SoundBuffer(Properties.Resources.down));
            soundBuffers.Add(Keys.Delete, new SoundBuffer(Properties.Resources.delete));

            foreach (Keys k in Enum.GetValues(typeof(Keys)))
            {
                soundDict[(int)k] = new Sound();
                if (soundBuffers.ContainsKey(k))
                {
                    soundDict[(int)k].SoundBuffer = soundBuffers[k];
                } 
                else if (k >= Keys.A && k <= Keys.Z)
                {
                    soundDict[(int)k].SoundBuffer = normalTypeBuffer;
                }
                
            }
            soundDict[copyCode] = new Sound();
            soundDict[pasteCode] = new Sound();
            soundDict[copyCode].SoundBuffer = copyBuffer;
            soundDict[pasteCode].SoundBuffer = pasteBuffer;
            continueSound.SoundBuffer = continueBuffer;
            normalTypeSound.SoundBuffer = normalTypeBuffer;
        }
    }
}
