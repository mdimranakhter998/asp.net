using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblPaymentStatus
{
    public int PaymentStatusId { get; set; }

    public string PaymentStatus { get; set; } = null!;

    public virtual ICollection<TblOrderPayment> TblOrderPayments { get; set; } = new List<TblOrderPayment>();
}
