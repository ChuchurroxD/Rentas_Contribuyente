using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using SGR.Entity.Model;
using SGR.Core.Repository;

namespace SGR.Core.Service
{
    public class Trib_FormatoCamposDataService
    {
        private static Trib_FormatoCamposRepository trib_FormatoCamposRepository = new Trib_FormatoCamposRepository();

        public int Insert(Trib_FormatoCampos trib_FormatoCampos)
        {
            return trib_FormatoCamposRepository.Insert(trib_FormatoCampos);
        }

        public int Update(Trib_FormatoCampos trib_FormatoCampos)
        {
            return trib_FormatoCamposRepository.Update(trib_FormatoCampos);
        }

        public virtual Trib_FormatoCampos mostrarCampos(String tipoFormato_ID, Int32 anio)
        {
            return trib_FormatoCamposRepository.mostrarCampos(tipoFormato_ID, anio);
        }

        public List<Trib_TipoFormato> llenarComboTipoformato()
        {
            return trib_FormatoCamposRepository.llenarComboTipoformato();
        }

        public List<Trib_FormatoCampos> buscarByAnio(int anio)
        {
            return trib_FormatoCamposRepository.buscarByAnio(anio);
        }

        public virtual List<Trib_FormatoCampos> buscarByAnioByColumna(int anio, string busqueda)
        {
            return trib_FormatoCamposRepository.buscarByAnioByColumna(anio, busqueda);
        }

        public virtual Int32 GetExisteFormatoCampoNuevo(String tipoFormato_ID, Int32 anio)
        {
            return trib_FormatoCamposRepository.GetExisteFormatoCampoNuevo(tipoFormato_ID, anio);
        }

        public virtual Int32 GetExisteFormatoCampoModificar(Int32 formatoCampos_ID, String tipoFormato_ID, Int32 anio)
        {
            return trib_FormatoCamposRepository.GetExisteFormatoCampoModificar(formatoCampos_ID, tipoFormato_ID, anio);
        }
    }
}
