﻿using UnityEngine.UI;
using UnityEngine;

namespace Geekbrains
{
    public sealed class DisplayBonuses
    {
        public Text _text;
        public DisplayBonuses()
        {
            _text = Object.FindObjectOfType<Text>();
        }
        
        public void Display(int value)
        {
            _text.text = $"Вы набрали {value}";
        }
    }
}