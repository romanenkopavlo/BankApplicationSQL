using System;
using System.Collections.Generic;

namespace CompteBancaireEF;

public partial class Transaction
{
    public long Id { get; set; }

    public long? IdCompte { get; set; }

    public string? Date { get; set; }

    public double? Montant { get; set; }

    public string? Notes { get; set; }

    public virtual Compte? IdCompteNavigation { get; set; }
}
