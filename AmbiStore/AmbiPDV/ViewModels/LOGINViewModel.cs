using AmbiPDV.Auxiliares;
using AmbiStore.Shared.EFCore.Data;
using AmbiStore.Shared.EFCore.Models;
using AmbiStore.Shared.Libraries.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static AmbiStore.Shared.Libraries.Static;

namespace AmbiPDV.ViewModels
{
    public class LOGINViewModel : ViewModelBase
    {
        private readonly AmbiStoreDbContext _context = new AmbiStoreDbContextFactory().CreateDbContext();

        public LOGINViewModel()
        {

        }

        internal void IniciaCaixa()
        {
            EMITENTE_STATIC = _context.EMITENTEs.Select(x => x).FirstOrDefault();
            if (EMITENTE_STATIC is null)
            {
                MessageBox.Show("Configure o Emitente pelo AmbiStore antes de executar outros módulos");
                Environment.Exit(0);
            }
        }
    }
}
