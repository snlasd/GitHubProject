using System;
using UnityEngine;

public interface IHasProgress
{
    public event EventHandler<OnProgressChangeEvenetArgs> OnProgressChanged;
    public class OnProgressChangeEvenetArgs : EventArgs
    {
        public float progressNormalized;
    }
}
