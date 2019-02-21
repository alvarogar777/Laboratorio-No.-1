using System;
namespace LaboratorioNo._1
{
    public interface IVisualizable
    {
         DateTime StartToSee(DateTime datel);
         void StopToSee(DateTime datel,DateTime datef);
    }
}