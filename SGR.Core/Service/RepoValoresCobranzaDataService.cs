using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using SGR.Entity.Model;
using SGR.Core.Repository;

namespace SGR.Core.Service
{
    public class RepoValoresCobranzaDataService
    {
        private RepoValoresCobranzaRepository repoValorezCobranzaRepository = new RepoValoresCobranzaRepository();
        public List<Valo_ValoresCobranzaReporte> listarValores(int notificacion_ID)
        {
            return repoValorezCobranzaRepository.listarValores(notificacion_ID);
        }
        public List<RepoValoresCobranza> datosContribuyente(int notificacion_id)
        {
            return repoValorezCobranzaRepository.datosContribuyente(notificacion_id);
        }

        public List<RepoValoresCobranza> todosPrediosDeclarados(String persona_id, Int32 idPeriodo)
        {
            return repoValorezCobranzaRepository.todosPrediosDeclarados(persona_id, idPeriodo);
        }

        public List<RepoValoresCobranza> predioDeclarado(String predio_id, Int32 idPeriodo)
        {
            return repoValorezCobranzaRepository.predioDeclarado(predio_id, idPeriodo);
        }

        public List<RepoValoresCobranza> detallePisos(String predio_id, Int32 idPeriodo)
        {
            return repoValorezCobranzaRepository.detallePisos(predio_id, idPeriodo);
        }

        public int numeroFolios(String persona_id, Int16 idPeriodo)
        {
            return repoValorezCobranzaRepository.numeroFolios(persona_id, idPeriodo);
        }

        public List<RepoValoresCobranza> documentosNotificados(int notificacion_ID)
        {
            return repoValorezCobranzaRepository.documentosNotificados(notificacion_ID);
        }

        public List<RepoValoresCobranza> liquidacionTributo(String persona_id, Int32 idPeriodo)
        {
            return repoValorezCobranzaRepository.liquidacionTributo(persona_id, idPeriodo);
        }

        public List<RepoValoresCobranza> detalleUIT(String persona_id, Int32 idPeriodo)
        {
            return repoValorezCobranzaRepository.detalleUIT(persona_id, idPeriodo);
        }
    }
}
