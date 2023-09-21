using System;
using System.Collections.Generic;

namespace Ecommerce.DataAccessLayer.Models;

public partial class TblOrderHeader
{
    public int OrderHeaderId { get; set; }

    public int CustomerUserId { get; set; }

    public int ShippingFeeId { get; set; }

    public int UserAddressId { get; set; }

    public double TotalCost { get; set; }

    public double DiscountAmount { get; set; }

    public double TotalPayment { get; set; }

    public DateTime OrderDate { get; set; }

    public TimeSpan OrderTime { get; set; }

    public DateTime ShippingDate { get; set; }

    public int OrderStatusId { get; set; }

    public int PaymentTypeId { get; set; }

    public string? TransactionNo { get; set; }

    public DateTime? TransactionDate { get; set; }

    public TimeSpan? TransactionTime { get; set; }

    public string? PaymentReceiptSnapshot { get; set; }

    public virtual TblUser CustomerUser { get; set; } = null!;

    public virtual TblOrderStatus OrderStatus { get; set; } = null!;

    public virtual TblPaymentType PaymentType { get; set; } = null!;

    public virtual TblShippingFee ShippingFee { get; set; } = null!;

    public virtual ICollection<TblCustomerReview> TblCustomerReviews { get; set; } = new List<TblCustomerReview>();

    public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; } = new List<TblOrderDetail>();

    public virtual ICollection<TblOrderPayment> TblOrderPayments { get; set; } = new List<TblOrderPayment>();

    public virtual TblUserAddress UserAddress { get; set; } = null!;
}
