using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CompteBancaireEF;

public partial class Compte
{
    public long Id { get; set; }

    public string? Proprietaire { get; set; }

    public long? Numero { get; set; }

    public virtual ObservableCollectionListSource<Transaction> Transactions { get; set; } = new ObservableCollectionListSource<Transaction>();
}
