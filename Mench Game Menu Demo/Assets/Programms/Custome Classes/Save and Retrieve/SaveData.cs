using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SaveAndRetrieve
{

    /// <summary>
    /// کلاس برای سیو و لود اطلاعات
    /// </summary>
    public class SaveData : SaveSystem
    {
        /// <summary>
        /// فایلی که ذخیره شده در سیستم رو لود میکنه و اماده نگه میداره
        /// </summary>
        public static void LoadDataFileFromSystem()
        {
            Load();
        }

        /// <summary>
        /// اطلاعات و دادهای درون بازی اصلی
        /// </summary>
        public class GameMatch
        {

        }
        /// <summary>
        /// اطلاعات و داده های درمورد پیکر بندی تنظیمات بازی
        /// </summary>
        public class GameOptions
        {
            /// <summary>
            /// میزان صدای کل بازی
            /// </summary>
            public static float GameMusicVolume
            {
                set
                {
                    SetFloat("GameSoundVolume", value);
                }
                get
                {
                    return GetFloat("GameSoundVolume", 1);
                }
            }
            /// <summary>
            /// میزان صدای کل بازی
            /// </summary>
            public static float GameSoundEffectsVolume
            {
                set
                {
                    SetFloat("GameSoundEffectsVolume", value);
                }
                get
                {
                    return GetFloat("GameSoundEffectsVolume", 1);
                }
            }
            /// <summary>
            /// ذخیره زبان بازی
            /// </summary>
            public static string GameLanguage
            {
                set
                {
                    SetString("GameLanguage", value);
                }
                get
                {
                    return GetString("GameLanguage", "English");
                }
            }
        }
        /// <summary>
        /// اطلاعات و داده های افتخاری درون بازی اصلی
        /// </summary>
        public class GameArchives
        {

        }
        /// <summary>
        /// اطلاعات ایتم های خریداری شده
        /// </summary>
        public class ItemsPurched
        {

        }

        public class GetDataByName
        {
            public uint GetUint(string Name)
            {
                return GetUint(Name);
            }
        }

        /// <summary>
        /// پاک کردن همه اطلاعات ذخیره شده بازی
        /// </summary>
        public static void ResetAllGameData()
        {
            Clear();
            Debug.Log("Game data deleted.");
        }
    }
}
