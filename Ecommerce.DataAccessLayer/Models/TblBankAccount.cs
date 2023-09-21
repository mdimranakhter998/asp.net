using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblBankAccount
{
    public int BankAccountId { get; set; }

    public int PaymentTypeId { get; set; }

    public string BankName { get; set; } = null!;

    public string AccountTitle { get; set; } = null!;

    public string AccountNo { get; set; } = null!;

    public string Ibanno { get; set; } = null!;

    public int StatusId { get; set; }

    public int CreatedByUserId { get; set; }

    public virtual TblUser CreatedByUser { get; set; } = null!;

    public virtual TblPaymentType PaymentType { get; set; } = null!;

    public virtual TblStatus Status { get; set; } = null!;
}
