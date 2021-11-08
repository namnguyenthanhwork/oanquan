using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BLL;
using DTO;
using GUI.Ultils;
using GUI.Ultils.FormAni;
using GUI.MessageBoxes;
using GUI.Ultils.Enum;

namespace GUI
{
    public static class Program
    {
        public static Dictionary<FormKind, Form> Dic_Forms;
        public static List<Form> List_HiddenForms;
        public static Dictionary<AnimationState, FormAnimation> Dic_Animations;
        public static Dictionary<string, object> Dic_Bundles;
        public static Dictionary<SoundKind, Ultilities.SoundUltils> Dic_Sounds;
        public static int MusicVolume = 50;
        public static int SoundVolume = 50;
        public static void changeForm(FormKind formKind, Form form, string titleMessage = "", string contentMessage = "")
        {
            Dic_Forms.Remove(formKind);
            Dic_Forms.Add(formKind, form);
            if (formKind == FormKind.YES_NO_MESSAGE_BOX || formKind == FormKind.OK_MESSAGE_BOX)
            {
                if (formKind == FormKind.YES_NO_MESSAGE_BOX)
                {
                    ((YesNoMessageBox)Dic_Forms[formKind]).TitleMessage = titleMessage;
                    ((YesNoMessageBox)Dic_Forms[formKind]).ContentMessage = contentMessage;
                }
                else
                {
                    ((OkMessageBox)Dic_Forms[formKind]).TitleMessage = titleMessage;
                    ((OkMessageBox)Dic_Forms[formKind]).ContentMessage = contentMessage;
                }
                Dic_Forms[formKind].ShowDialog();
            }
            else
                Dic_Forms[formKind].Show();
        }
        public static void runAnimation(AnimationState animationState, Form form)
        {
            int delay = 100;
            while ((--delay) > 0) { }
            switch (animationState)
            {
                case AnimationState.DISAPPEAR:
                    Dic_Animations[animationState] = new DisappearAnimation(form);
                    break;
                case AnimationState.FLOAT:
                    Dic_Animations[animationState] = new FloatAnimation(form);
                    break;
                case AnimationState.SINK:
                    Dic_Animations[animationState] = new SinkAnimation(form);
                    break;
                case AnimationState.ZOOM_IN:
                    Dic_Animations[animationState] = new ZoomInAnimation(form);
                    break;
                case AnimationState.SCALING_UP:
                    Dic_Animations[animationState] = new ScalingUp(form);
                    break;
                case AnimationState.SCALING_DOWN:
                    Dic_Animations[animationState] = new ScalingDown(form);
                    break;
                case AnimationState.SCROLL_UP:
                    Dic_Animations[animationState] = new ScrollUp(form);
                    break;
                case AnimationState.SCROLL_DOWN:
                    Dic_Animations[animationState] = new ScrollDown(form);
                    break;
            }

            Dic_Animations[animationState].run();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List_HiddenForms = new List<Form>();
            Dic_Forms = new Dictionary<FormKind, Form>();
            Dic_Animations = new Dictionary<AnimationState, FormAnimation>();
            Dic_Bundles = new Dictionary<string, object>() {
                { StringManagement.KeyDatas.AccountBLL_Key, new AccountBLL() },
                { StringManagement.KeyDatas.AccountDTO_Key, new AccountDTO() },
                { StringManagement.KeyDatas.CharacterDTO_Key, new CharacterDTO() },
                { StringManagement.KeyDatas.CharacterBLL_Key, new CharacterBLL() }
            };
            Dic_Sounds = new Dictionary<SoundKind, Ultilities.SoundUltils>() {
                { SoundKind.OPENING_MUSIC, new Ultilities.SoundUltils(SoundPath.openingMusic)},
                { SoundKind.MAIN_MUSIC, new Ultilities.SoundUltils(SoundPath.mainMusic)},
                { SoundKind.CHOICE_SOUND, new Ultilities.SoundUltils(SoundPath.choiceSound)},
                { SoundKind.TICK_SOUND, new Ultilities.SoundUltils(SoundPath.tickSound)},
                { SoundKind.TIMEUP_SOUND, new Ultilities.SoundUltils(SoundPath.timeUp_Sound)},
                { SoundKind.FAST_TICK_SOUND, new Ultilities.SoundUltils(SoundPath.fastTickSound)},
                { SoundKind.STONE_DROPPING_SOUND, new Ultilities.SoundUltils(SoundPath.stoneDroppingSound)},

            };
            foreach (SoundKind soundKind in Dic_Sounds.Keys)
                Dic_Sounds[soundKind].windowsMediaPlayer.settings.volume = MusicVolume;
            Dic_Sounds[SoundKind.OPENING_MUSIC].windowsMediaPlayer.settings.setMode("loop", true);
            Dic_Sounds[SoundKind.OPENING_MUSIC].windowsMediaPlayer.controls.play();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Dic_Forms.Add(FormKind.LOG_IN, new LogInGUI());
            Application.Run(Dic_Forms[FormKind.LOG_IN]);
        }
    }
}
