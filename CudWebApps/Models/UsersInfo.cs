using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class UsersInfo
{
    public Guid UserGuid { get; set; }

    public string UserName { get; set; } = null!;

    public string? Password { get; set; }

    public string? EmailAddress { get; set; }

    public bool? IsEmailVerified { get; set; }

    public string? FullName { get; set; }

    public string? CompanyName { get; set; }

    public string? ContactNo { get; set; }

    public long? CityId { get; set; }

    public string? MembershipType { get; set; }

    public DateTime? MembershipUpdated { get; set; }

    public string? BuyerTypeCode { get; set; }

    public string? SellerDiscCodes { get; set; }

    public double? SellerTopDiscPer { get; set; }

    public DateTime? ValidUpto { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool? IsEnabled { get; set; }

    public string? EmailVerifyCode { get; set; }

    public string? MobileVerifyCode { get; set; }

    public bool? IsMobileVerified { get; set; }

    public string? LoginOtp { get; set; }

    public DateTime? Otpdate { get; set; }

    public string? SignupVia { get; set; }

    public virtual ICollection<Pitem> Pitems { get; set; } = new List<Pitem>();
}
