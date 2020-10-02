using System;
using System.Collections.Generic;
using System.Text;

namespace YuceEgitim.Entites
{
    public interface ISilinebilinir
    {
        bool Silindi { get; set; }
    }

    interface IIdentity
    {
        int Id { get; set; }
    }

    public abstract class BaseEntity : IIdentity, ISilinebilinir
    {
        public int Id { get; set; }
        public bool Silindi { get; set; }
    }

}
