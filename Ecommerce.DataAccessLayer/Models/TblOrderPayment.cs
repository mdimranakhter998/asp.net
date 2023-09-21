using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblOrderPayment
{
    public int OrderPaymentId { get; set; }

    public int OrderHeaderId { get; set; }

    public double TotalPayment { get; set; }

    public string PaymentGateway { get; set; } = null!;

    public int PaymentTypeId { get; set; }

    public int PaymentStatusId { get; set; }

    public virtual TblOrderHeader OrderHeader { get; set; } = null!;

    public virtual TblPaymentStatus PaymentStatus { get; set; } = null!;

    public virtual TblPaymentType PaymentType { get; set; } = null!;
}
