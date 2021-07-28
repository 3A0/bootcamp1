using DIO.Series.Classes;
using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        void Atualiza(int id, Serie objeto);
        void Exclui(int id);
        List<Serie> Lista();

        int ProximoId();

        Serie RetornaPorId(int id);
    }
}
