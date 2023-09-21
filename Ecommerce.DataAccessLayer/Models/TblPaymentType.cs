using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblPaymentType
{
    public int PaymentTypeId { get; set; }

    public string PaymentType { get; set; } = null!;

    public virtual ICollection<TblBankAccount> TblBankAccounts { get; set; } = new List<TblBankAccount>();

    public virtual ICollection<TblOrderHeader> TblOrderHeaders { get; set; } = new List<TblOrderHeader>();

    public virtual ICollection<TblOrderPayment> TblOrderPayments { get; set; } = new List<TblOrderPayment>();
}
