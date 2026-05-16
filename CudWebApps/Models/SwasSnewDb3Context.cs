using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CudWebApps.Models;

public partial class SwasSnewDb3Context : DbContext
{
    public SwasSnewDb3Context()
    {
    }

    public SwasSnewDb3Context(DbContextOptions<SwasSnewDb3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<ApplyOffer> ApplyOffers { get; set; }

    public virtual DbSet<AspnetApplication> AspnetApplications { get; set; }

    public virtual DbSet<AspnetMembership> AspnetMemberships { get; set; }

    public virtual DbSet<AspnetPath> AspnetPaths { get; set; }

    public virtual DbSet<AspnetPersonalizationAllUser> AspnetPersonalizationAllUsers { get; set; }

    public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; }

    public virtual DbSet<AspnetProfile> AspnetProfiles { get; set; }

    public virtual DbSet<AspnetRole> AspnetRoles { get; set; }

    public virtual DbSet<AspnetSchemaVersion> AspnetSchemaVersions { get; set; }

    public virtual DbSet<AspnetUser> AspnetUsers { get; set; }

    public virtual DbSet<AspnetWebEventEvent> AspnetWebEventEvents { get; set; }

    public virtual DbSet<BillingAndShipping> BillingAndShippings { get; set; }

    public virtual DbSet<BillingAndShippingAddress> BillingAndShippingAddresses { get; set; }

    public virtual DbSet<Blog> Blogs { get; set; }

    public virtual DbSet<BlogCategory> BlogCategories { get; set; }

    public virtual DbSet<BuyerDiscountMatrix> BuyerDiscountMatrices { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Codamount> Codamounts { get; set; }

    public virtual DbSet<ContactU> ContactUs { get; set; }

    public virtual DbSet<DefCont> DefConts { get; set; }

    public virtual DbSet<DiscountBy> DiscountBies { get; set; }

    public virtual DbSet<DiscountCoupon> DiscountCoupons { get; set; }

    public virtual DbSet<FreeShippingAmount> FreeShippingAmounts { get; set; }

    public virtual DbSet<GoQuicklyToLink> GoQuicklyToLinks { get; set; }

    public virtual DbSet<Hpheading> Hpheadings { get; set; }

    public virtual DbSet<LinkType> LinkTypes { get; set; }

    public virtual DbSet<LinksInfo> LinksInfos { get; set; }

    public virtual DbSet<MyLoyaltyPoint> MyLoyaltyPoints { get; set; }

    public virtual DbSet<NewsLetterTemplate> NewsLetterTemplates { get; set; }

    public virtual DbSet<NewsletterMember> NewsletterMembers { get; set; }

    public virtual DbSet<Offer> Offers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<OrderReview> OrderReviews { get; set; }

    public virtual DbSet<PartnerRequest> PartnerRequests { get; set; }

    public virtual DbSet<PaymentReminderHistory> PaymentReminderHistories { get; set; }

    public virtual DbSet<Pbrand> Pbrands { get; set; }

    public virtual DbSet<Pcategory> Pcategories { get; set; }

    public virtual DbSet<Pincode> Pincodes { get; set; }

    public virtual DbSet<Pitem> Pitems { get; set; }

    public virtual DbSet<PitemComment> PitemComments { get; set; }

    public virtual DbSet<PitemOffer> PitemOffers { get; set; }

    public virtual DbSet<PitemPicture> PitemPictures { get; set; }

    public virtual DbSet<ProductReview> ProductReviews { get; set; }

    public virtual DbSet<Punit> Punits { get; set; }

    public virtual DbSet<ReferToFriend> ReferToFriends { get; set; }

    public virtual DbSet<SetLoyaltyPoint> SetLoyaltyPoints { get; set; }

    public virtual DbSet<SetLoyaltyPointsValue> SetLoyaltyPointsValues { get; set; }

    public virtual DbSet<ShipRegionCity> ShipRegionCities { get; set; }

    public virtual DbSet<ShippingPolicy> ShippingPolicies { get; set; }

    public virtual DbSet<ShippingRegion> ShippingRegions { get; set; }

    public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<UsersInfo> UsersInfos { get; set; }

    public virtual DbSet<VwAspnetApplication> VwAspnetApplications { get; set; }

    public virtual DbSet<VwAspnetMembershipUser> VwAspnetMembershipUsers { get; set; }

    public virtual DbSet<VwAspnetProfile> VwAspnetProfiles { get; set; }

    public virtual DbSet<VwAspnetRole> VwAspnetRoles { get; set; }

    public virtual DbSet<VwAspnetUser> VwAspnetUsers { get; set; }

    public virtual DbSet<VwAspnetUsersInRole> VwAspnetUsersInRoles { get; set; }

    public virtual DbSet<VwAspnetWebPartStatePath> VwAspnetWebPartStatePaths { get; set; }

    public virtual DbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShareds { get; set; }

    public virtual DbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUsers { get; set; }

    public virtual DbSet<Wishlist> Wishlists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-ONF0QGQ;Database=SwasSnewDb3;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApplyOffer>(entity =>
        {
            entity.Property(e => e.ApplyOfferId).HasColumnName("ApplyOfferID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.OfferId).HasColumnName("OfferID");

            entity.HasOne(d => d.Offer).WithMany(p => p.ApplyOffers)
                .HasForeignKey(d => d.OfferId)
                .HasConstraintName("FK_ApplyOffers_Offers");
        });

        modelBuilder.Entity<AspnetApplication>(entity =>
        {
            entity.HasKey(e => e.ApplicationId)
                .HasName("PK__aspnet_A__C93A4C9804AFB25B")
                .IsClustered(false);

            entity.ToTable("aspnet_Applications");

            entity.HasIndex(e => e.LoweredApplicationName, "UQ__aspnet_A__17477DE401D345B0").IsUnique();

            entity.HasIndex(e => e.ApplicationName, "UQ__aspnet_A__309103317EF6D905").IsUnique();

            entity.HasIndex(e => e.LoweredApplicationName, "aspnet_Applications_Index").IsClustered();

            entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ApplicationName).HasMaxLength(256);
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.LoweredApplicationName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspnetMembership>(entity =>
        {
            entity.HasKey(e => e.UserId)
                .HasName("PK__aspnet_M__1788CC4D477199F1")
                .IsClustered(false);

            entity.ToTable("aspnet_Membership");

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail }, "aspnet_Membership_index").IsClustered();

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Comment).HasColumnType("ntext");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");
            entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");
            entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");
            entity.Property(e => e.LoweredEmail).HasMaxLength(256);
            entity.Property(e => e.MobilePin)
                .HasMaxLength(16)
                .HasColumnName("MobilePIN");
            entity.Property(e => e.Password).HasMaxLength(128);
            entity.Property(e => e.PasswordAnswer).HasMaxLength(128);
            entity.Property(e => e.PasswordQuestion).HasMaxLength(256);
            entity.Property(e => e.PasswordSalt).HasMaxLength(128);

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetMemberships)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Me__Appli__0FEC5ADD");

            entity.HasOne(d => d.User).WithOne(p => p.AspnetMembership)
                .HasForeignKey<AspnetMembership>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Me__UserI__10E07F16");
        });

        modelBuilder.Entity<AspnetPath>(entity =>
        {
            entity.HasKey(e => e.PathId)
                .HasName("PK__aspnet_P__CD67DC5809746778")
                .IsClustered(false);

            entity.ToTable("aspnet_Paths");

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredPath }, "aspnet_Paths_index")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.LoweredPath).HasMaxLength(256);
            entity.Property(e => e.Path).HasMaxLength(256);

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetPaths)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Pa__Appli__11D4A34F");
        });

        modelBuilder.Entity<AspnetPersonalizationAllUser>(entity =>
        {
            entity.HasKey(e => e.PathId).HasName("PK__aspnet_P__CD67DC594D2A7347");

            entity.ToTable("aspnet_PersonalizationAllUsers");

            entity.Property(e => e.PathId).ValueGeneratedNever();
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.PageSettings).HasColumnType("image");

            entity.HasOne(d => d.Path).WithOne(p => p.AspnetPersonalizationAllUser)
                .HasForeignKey<AspnetPersonalizationAllUser>(d => d.PathId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Pe__PathI__12C8C788");
        });

        modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK__aspnet_P__3214EC063EDC53F0")
                .IsClustered(false);

            entity.ToTable("aspnet_PersonalizationPerUser");

            entity.HasIndex(e => new { e.PathId, e.UserId }, "aspnet_PersonalizationPerUser_index1")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => new { e.UserId, e.PathId }, "aspnet_PersonalizationPerUser_ncindex2").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.PageSettings).HasColumnType("image");

            entity.HasOne(d => d.Path).WithMany(p => p.AspnetPersonalizationPerUsers)
                .HasForeignKey(d => d.PathId)
                .HasConstraintName("FK__aspnet_Pe__PathI__13BCEBC1");

            entity.HasOne(d => d.User).WithMany(p => p.AspnetPersonalizationPerUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__aspnet_Pe__UserI__14B10FFA");
        });

        modelBuilder.Entity<AspnetProfile>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__aspnet_P__1788CC4C43A1090D");

            entity.ToTable("aspnet_Profile");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.PropertyNames).HasColumnType("ntext");
            entity.Property(e => e.PropertyValuesBinary).HasColumnType("image");
            entity.Property(e => e.PropertyValuesString).HasColumnType("ntext");

            entity.HasOne(d => d.User).WithOne(p => p.AspnetProfile)
                .HasForeignKey<AspnetProfile>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Pr__UserI__15A53433");
        });

        modelBuilder.Entity<AspnetRole>(entity =>
        {
            entity.HasKey(e => e.RoleId)
                .HasName("PK__aspnet_R__8AFACE1B0F2D40CE")
                .IsClustered(false);

            entity.ToTable("aspnet_Roles");

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName }, "aspnet_Roles_index1")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.LoweredRoleName).HasMaxLength(256);
            entity.Property(e => e.RoleName).HasMaxLength(256);

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetRoles)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Ro__Appli__1699586C");
        });

        modelBuilder.Entity<AspnetSchemaVersion>(entity =>
        {
            entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion }).HasName("PK__aspnet_S__5A1E6BC17B264821");

            entity.ToTable("aspnet_SchemaVersions");

            entity.Property(e => e.Feature).HasMaxLength(128);
            entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
        });

        modelBuilder.Entity<AspnetUser>(entity =>
        {
            entity.HasKey(e => e.UserId)
                .HasName("PK__aspnet_U__1788CC4D14E61A24")
                .IsClustered(false);

            entity.ToTable("aspnet_Users");

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName }, "aspnet_Users_Index")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate }, "aspnet_Users_Index2");

            entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
            entity.Property(e => e.LoweredUserName).HasMaxLength(256);
            entity.Property(e => e.MobileAlias)
                .HasMaxLength(16)
                .HasDefaultValueSql("(NULL)");
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetUsers)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Us__Appli__178D7CA5");

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspnetUsersInRole",
                    r => r.HasOne<AspnetRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__aspnet_Us__RoleI__1881A0DE"),
                    l => l.HasOne<AspnetUser>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__aspnet_Us__UserI__1975C517"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK__aspnet_U__AF2760AD3B0BC30C");
                        j.ToTable("aspnet_UsersInRoles");
                        j.HasIndex(new[] { "RoleId" }, "aspnet_UsersInRoles_index");
                    });
        });

        modelBuilder.Entity<AspnetWebEventEvent>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__aspnet_W__7944C810756D6ECB");

            entity.ToTable("aspnet_WebEvent_Events");

            entity.Property(e => e.EventId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ApplicationPath).HasMaxLength(256);
            entity.Property(e => e.ApplicationVirtualPath).HasMaxLength(256);
            entity.Property(e => e.Details).HasColumnType("ntext");
            entity.Property(e => e.EventOccurrence).HasColumnType("decimal(19, 0)");
            entity.Property(e => e.EventSequence).HasColumnType("decimal(19, 0)");
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.EventTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.EventType).HasMaxLength(256);
            entity.Property(e => e.ExceptionType).HasMaxLength(256);
            entity.Property(e => e.MachineName).HasMaxLength(256);
            entity.Property(e => e.Message).HasMaxLength(1024);
            entity.Property(e => e.RequestUrl).HasMaxLength(1024);
        });

        modelBuilder.Entity<BillingAndShipping>(entity =>
        {
            entity.HasKey(e => e.RegId);

            entity.ToTable("BillingAndShipping");

            entity.Property(e => e.RegId).HasColumnName("RegID");
            entity.Property(e => e.CardUserName).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CmpnyAddress).HasMaxLength(200);
            entity.Property(e => e.CmpnyName).HasMaxLength(150);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.Gstnumber)
                .HasMaxLength(150)
                .HasColumnName("GSTNumber");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.ShipCity).HasMaxLength(50);
            entity.Property(e => e.ShipCountry).HasMaxLength(50);
            entity.Property(e => e.ShipName).HasMaxLength(100);
            entity.Property(e => e.ShipState).HasMaxLength(50);
            entity.Property(e => e.ShipStreetAddress).HasMaxLength(250);
            entity.Property(e => e.ShipZip).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.StreetAddress).HasMaxLength(250);
            entity.Property(e => e.Zip).HasMaxLength(20);
        });

        modelBuilder.Entity<BillingAndShippingAddress>(entity =>
        {
            entity.HasKey(e => e.PrimaryKey).HasName("PK_BillingAndShippingaddress");

            entity.ToTable("BillingAndShippingAddress");

            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.ShipCity).HasMaxLength(50);
            entity.Property(e => e.ShipCountry).HasMaxLength(50);
            entity.Property(e => e.ShipEmail).HasMaxLength(150);
            entity.Property(e => e.ShipName).HasMaxLength(100);
            entity.Property(e => e.ShipPhone).HasMaxLength(20);
            entity.Property(e => e.ShipState).HasMaxLength(50);
            entity.Property(e => e.ShipStreetAddress).HasMaxLength(250);
            entity.Property(e => e.ShipZip).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.StreetAddress).HasMaxLength(250);
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
            entity.Property(e => e.Zip).HasMaxLength(20);
        });

        modelBuilder.Entity<Blog>(entity =>
        {
            entity.ToTable("Blog");

            entity.Property(e => e.BlogId).HasColumnName("BlogID");
            entity.Property(e => e.BlogContents).HasColumnType("text");
            entity.Property(e => e.BlogHeading).HasMaxLength(250);
            entity.Property(e => e.BlogLastUpdate).HasColumnType("datetime");
            entity.Property(e => e.BlogOrderId).HasColumnName("BlogOrderID");
            entity.Property(e => e.BlogPublishDate).HasColumnType("datetime");
            entity.Property(e => e.BlogStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.BlogUniqueUrl)
                .HasMaxLength(255)
                .HasColumnName("BlogUniqueURL");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.ExUrl)
                .HasMaxLength(255)
                .HasColumnName("ExURL");
            entity.Property(e => e.MetaAuthor).HasMaxLength(255);
            entity.Property(e => e.MetaDescription).HasMaxLength(255);
            entity.Property(e => e.MetaKeywords).HasMaxLength(255);
            entity.Property(e => e.UploadImage)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UseUrl).HasColumnName("UseURL");
            entity.Property(e => e.WindowTitle).HasMaxLength(255);
        });

        modelBuilder.Entity<BlogCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.ToTable("BlogCategory");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<BuyerDiscountMatrix>(entity =>
        {
            entity.HasKey(e => e.MatRowId);

            entity.ToTable("BuyerDiscountMatrix");

            entity.Property(e => e.MatRowId).HasColumnName("MatRowID");
            entity.Property(e => e.BuyerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DiscountColor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CityName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StateId).HasColumnName("StateID");

            entity.HasOne(d => d.State).WithMany(p => p.Cities)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_Cities_States");
        });

        modelBuilder.Entity<Codamount>(entity =>
        {
            entity.HasKey(e => e.Codid).HasName("PK__CODAmoun__F256EBBFAC91425C");

            entity.ToTable("CODAmount");

            entity.Property(e => e.Codid).HasColumnName("CODID");
            entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<ContactU>(entity =>
        {
            entity.HasKey(e => e.ContactId);

            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.EmailId)
                .HasMaxLength(500)
                .HasColumnName("EmailID");
            entity.Property(e => e.Fax).HasMaxLength(150);
            entity.Property(e => e.InsertedOn).HasColumnType("datetime");
            entity.Property(e => e.MobileNo).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.State).HasMaxLength(50);
        });

        modelBuilder.Entity<DefCont>(entity =>
        {
            entity.HasKey(e => e.DefConId);

            entity.Property(e => e.DefConId).HasColumnName("DefConID");
            entity.Property(e => e.DefConText).HasColumnType("text");
        });

        modelBuilder.Entity<DiscountBy>(entity =>
        {
            entity.HasKey(e => e.DisctId);

            entity.ToTable("DiscountBy");

            entity.Property(e => e.DisctId).HasColumnName("DisctID");
            entity.Property(e => e.DidctByName).HasMaxLength(100);
            entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DisctById).HasColumnName("DisctByID");
        });

        modelBuilder.Entity<DiscountCoupon>(entity =>
        {
            entity.HasKey(e => e.CouponId);

            entity.ToTable("DiscountCoupon");

            entity.Property(e => e.CouponId).HasColumnName("CouponID");
            entity.Property(e => e.BrandId).HasColumnName("BrandID");
            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.CouponCode).HasMaxLength(20);
            entity.Property(e => e.CouponDescription).HasMaxLength(500);
            entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.PitemId).HasColumnName("PItemID");
            entity.Property(e => e.ShippingCoupon).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<FreeShippingAmount>(entity =>
        {
            entity.HasKey(e => e.FreeShippingId);

            entity.ToTable("FreeShippingAmount");

            entity.Property(e => e.FreeShippingId).HasColumnName("FreeShippingID");
            entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<GoQuicklyToLink>(entity =>
        {
            entity.HasKey(e => e.LinkId);

            entity.Property(e => e.LinkId).HasColumnName("LinkID");
            entity.Property(e => e.LinkName).HasMaxLength(50);
            entity.Property(e => e.LinkUrl)
                .HasMaxLength(255)
                .HasColumnName("LinkURL");
            entity.Property(e => e.OrderId)
                .HasDefaultValue(0, "DF_GoQuicklyToLinks_OrderID")
                .HasColumnName("OrderID");
        });

        modelBuilder.Entity<Hpheading>(entity =>
        {
            entity.HasKey(e => e.HeadingId);

            entity.ToTable("HPHeading");

            entity.Property(e => e.Heading1).HasMaxLength(50);
            entity.Property(e => e.Heading2).HasMaxLength(50);
        });

        modelBuilder.Entity<LinkType>(entity =>
        {
            entity.Property(e => e.LinkTypeId).HasColumnName("LinkTypeID");
            entity.Property(e => e.LinkTypeName).HasMaxLength(20);
        });

        modelBuilder.Entity<LinksInfo>(entity =>
        {
            entity.HasKey(e => e.SLinkId);

            entity.ToTable("LinksInfo");

            entity.Property(e => e.SLinkId).HasColumnName("sLinkID");
            entity.Property(e => e.ArticleUniqueUrl)
                .HasMaxLength(255)
                .HasColumnName("ArticleUniqueURL");
            entity.Property(e => e.ExUrl)
                .HasMaxLength(255)
                .HasColumnName("ExURL");
            entity.Property(e => e.IsLinkActive).HasDefaultValue(true, "DF_LinksInfo_IsLinkActive");
            entity.Property(e => e.LinkContents).HasColumnType("text");
            entity.Property(e => e.LinkLastUpdate)
                .HasDefaultValueSql("(getdate())", "DF_LinksInfo_LinkLastUpdate")
                .HasColumnType("datetime");
            entity.Property(e => e.LinkOrderId)
                .HasDefaultValue(0, "DF_LinksInfo_LinkOrderID")
                .HasColumnName("LinkOrderID");
            entity.Property(e => e.LinkTypeId).HasColumnName("LinkTypeID");
            entity.Property(e => e.MetaDescription).HasMaxLength(255);
            entity.Property(e => e.MetaKeywords).HasMaxLength(255);
            entity.Property(e => e.ParentLinkId).HasColumnName("ParentLinkID");
            entity.Property(e => e.SLinkName)
                .HasMaxLength(150)
                .HasColumnName("sLinkName");
            entity.Property(e => e.UseUrl).HasColumnName("UseURL");
            entity.Property(e => e.WindowTitle).HasMaxLength(255);
        });

        modelBuilder.Entity<MyLoyaltyPoint>(entity =>
        {
            entity.HasKey(e => e.LoyaltyPointId);

            entity.Property(e => e.LoyaltyPointId).HasColumnName("LoyaltyPointID");
            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.DateStamp).HasColumnType("datetime");
            entity.Property(e => e.IsExpired).HasDefaultValue(false, "DF_MyLoyaltyPoints_IsExpired");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
            entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<NewsLetterTemplate>(entity =>
        {
            entity.HasKey(e => e.Nlid);

            entity.Property(e => e.Nlid).HasColumnName("NLID");
            entity.Property(e => e.Nlbody)
                .HasColumnType("text")
                .HasColumnName("NLBody");
            entity.Property(e => e.NlcreateDate)
                .HasDefaultValueSql("(getdate())", "DF_NewsLetterTemplates_NLCreateDate")
                .HasColumnType("datetime")
                .HasColumnName("NLCreateDate");
            entity.Property(e => e.Nlsubject)
                .HasMaxLength(255)
                .HasColumnName("NLSubject");
            entity.Property(e => e.NlupdateDate)
                .HasDefaultValueSql("(getdate())", "DF_NewsLetterTemplates_NLUpdateDate")
                .HasColumnType("datetime")
                .HasColumnName("NLUpdateDate");
        });

        modelBuilder.Entity<NewsletterMember>(entity =>
        {
            entity.HasKey(e => e.SubsId);

            entity.Property(e => e.SubsId).HasColumnName("SubsID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasDefaultValue("D", "DF_NewsletterMembers_Status");
            entity.Property(e => e.SubsDate)
                .HasDefaultValueSql("(getdate())", "DF_NewsletterMembers_SubsDate")
                .HasColumnType("datetime");
            entity.Property(e => e.SubsEmail).HasMaxLength(150);
            entity.Property(e => e.SubsGuid)
                .HasDefaultValueSql("(newid())", "DF_Table_1_SubGUID")
                .HasColumnName("SubsGUID");
            entity.Property(e => e.UnSubsDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Offer>(entity =>
        {
            entity.HasKey(e => e.OfferId).HasName("PK_Offers_1");

            entity.Property(e => e.OfferId).HasColumnName("OfferID");
            entity.Property(e => e.CreatedFor).HasMaxLength(50);
            entity.Property(e => e.ExpiringDate).HasColumnType("datetime");
            entity.Property(e => e.ItemUnit).HasMaxLength(10);
            entity.Property(e => e.OfferDescription).HasColumnType("ntext");
            entity.Property(e => e.OfferPrice).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ShippingDelhiNcrcharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ShippingDelhiNCRCharges");
            entity.Property(e => e.ShippingNorthIndiaCharges).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ShippingRoicharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ShippingROICharges");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.AirWayBillNo).HasMaxLength(125);
            entity.Property(e => e.CouponCode).HasMaxLength(20);
            entity.Property(e => e.CouponDiscount).HasColumnType("money");
            entity.Property(e => e.CourierInfo).HasMaxLength(125);
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())", "DF_Orders_CreatedOn")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(150)
                .HasColumnName("CustomerID");
            entity.Property(e => e.CustomerPinCode).HasMaxLength(20);
            entity.Property(e => e.CustomerStateId).HasColumnName("CustomerStateID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_Orders_IsDeleted");
            entity.Property(e => e.LastUpdate).HasMaxLength(128);
            entity.Property(e => e.LoyaltyDiscount).HasColumnType("money");
            entity.Property(e => e.NoCouponSubTotal)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.OrderGuid)
                .HasDefaultValueSql("(newid())", "DF_Orders_OrderGUID")
                .HasColumnName("OrderGUID");
            entity.Property(e => e.OrderShipping).HasColumnType("money");
            entity.Property(e => e.OrderSubTotal).HasColumnType("money");
            entity.Property(e => e.OrderTax).HasColumnType("money");
            entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");
            entity.Property(e => e.PaymentMethodName).HasMaxLength(100);
            entity.Property(e => e.PaymentStatus).HasMaxLength(1);
            entity.Property(e => e.Txcommand)
                .HasMaxLength(4000)
                .HasColumnName("TXCommand");
            entity.Property(e => e.Txid)
                .HasMaxLength(100)
                .HasColumnName("TXID");
            entity.Property(e => e.Txresults)
                .HasMaxLength(4000)
                .HasColumnName("TXResults");
            entity.Property(e => e.Txstate)
                .HasMaxLength(100)
                .HasColumnName("TXState");
            entity.Property(e => e.Txstatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasDefaultValue("U", "DF_Orders_TXStatus")
                .HasColumnName("TXStatus");
            entity.Property(e => e.TxupdatedOn)
                .HasColumnType("datetime")
                .HasColumnName("TXUpdatedOn");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatesHistory).HasColumnType("text");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.Property(e => e.OrderItemId).HasColumnName("OrderItemID");
            entity.Property(e => e.Discount)
                .HasDefaultValue(0m, "DF_OrderItems_Discount")
                .HasColumnType("decimal(6, 2)");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PriceToPay)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.SavedAmount).HasColumnType("money");
            entity.Property(e => e.TextOption).HasMaxLength(400);
            entity.Property(e => e.UnitPrice).HasColumnType("money");
            entity.Property(e => e.UnitShipping).HasColumnType("money");
        });

        modelBuilder.Entity<OrderReview>(entity =>
        {
            entity.Property(e => e.Attachment)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Rating)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Review).HasColumnType("text");
            entity.Property(e => e.UserGuid).HasColumnName("UserGUID");
        });

        modelBuilder.Entity<PartnerRequest>(entity =>
        {
            entity.HasKey(e => e.ReqId);

            entity.Property(e => e.ReqId).HasColumnName("ReqID");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CompanyName).HasMaxLength(150);
            entity.Property(e => e.ContactNo).HasMaxLength(20);
            entity.Property(e => e.EmailAddress).HasMaxLength(150);
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.Message).HasColumnType("text");
            entity.Property(e => e.RequestedOn).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Subject).HasMaxLength(255);
        });

        modelBuilder.Entity<PaymentReminderHistory>(entity =>
        {
            entity.ToTable("PaymentReminderHistory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(300)
                .HasColumnName("CustomerID");
            entity.Property(e => e.OrderGuid).HasColumnName("OrderGUID");
        });

        modelBuilder.Entity<Pbrand>(entity =>
        {
            entity.HasKey(e => e.BrandId);

            entity.ToTable("PBrands");

            entity.Property(e => e.BrandId).HasColumnName("BrandID");
            entity.Property(e => e.BrandAbout).HasColumnType("text");
            entity.Property(e => e.BrandLogo).HasMaxLength(50);
            entity.Property(e => e.BrandName).HasMaxLength(75);
            entity.Property(e => e.Brandtype).HasMaxLength(50);
            entity.Property(e => e.OrderId)
                .HasDefaultValue(0, "DF_PBrands_OrderID")
                .HasColumnName("OrderID");
            entity.Property(e => e.Status).HasDefaultValue(true, "DF_PBrands_Status");
        });

        modelBuilder.Entity<Pcategory>(entity =>
        {
            entity.ToTable("PCategories", tb => tb.HasTrigger("OnCategoryInsert"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ArticleUniqueUrl)
                .HasMaxLength(255)
                .HasColumnName("ArticleUniqueURL");
            entity.Property(e => e.BannerImage).HasMaxLength(50);
            entity.Property(e => e.BannerUrl)
                .HasMaxLength(255)
                .HasColumnName("BannerURL");
            entity.Property(e => e.BgImageColor).HasMaxLength(10);
            entity.Property(e => e.BgImagePath).HasMaxLength(25);
            entity.Property(e => e.CategoryBrief).HasMaxLength(255);
            entity.Property(e => e.CategoryDescription).HasColumnType("text");
            entity.Property(e => e.CategoryName).HasMaxLength(120);
            entity.Property(e => e.CategoryThumb).HasMaxLength(50);
            entity.Property(e => e.LinkId)
                .HasMaxLength(500)
                .HasColumnName("LinkID");
            entity.Property(e => e.MetaDescription).HasMaxLength(255);
            entity.Property(e => e.MetaKeywords).HasMaxLength(255);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ParentCategoryId).HasColumnName("ParentCategoryID");
            entity.Property(e => e.Path).HasMaxLength(1024);
            entity.Property(e => e.WindowTitle).HasMaxLength(255);
        });

        modelBuilder.Entity<Pincode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Pincode");

            entity.Property(e => e.ActiveFlag).HasMaxLength(50);
            entity.Property(e => e.Branch).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.LocCode).HasMaxLength(50);
            entity.Property(e => e.Pincode1)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Pincode");
            entity.Property(e => e.Region).HasMaxLength(50);
            entity.Property(e => e.RoutingCode).HasMaxLength(50);
            entity.Property(e => e.Zone).HasMaxLength(50);
        });

        modelBuilder.Entity<Pitem>(entity =>
        {
            entity.ToTable("PItems");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())", "DF_PItems_AddedOn_1")
                .HasColumnType("datetime");
            entity.Property(e => e.ArticleUniqueUrl)
                .HasMaxLength(255)
                .HasColumnName("ArticleUniqueURL");
            entity.Property(e => e.BrandId).HasColumnName("BrandID");
            entity.Property(e => e.BriefDescrip)
                .HasMaxLength(255)
                .HasColumnName("briefDescrip");
            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.DimBr).HasComment("Dimensional BREADTH in inches as per product specification, later converted to required units for the calculation of logistics requirement");
            entity.Property(e => e.DimHt).HasComment("Dimensional HEIGHT in inches as per product specification, later converted to required units for the calculation of logistics requirement");
            entity.Property(e => e.DimLn).HasComment("Dimensional LENGTH in inches as per product specification, later converted to required units for the calculation of logistics requirement");
            entity.Property(e => e.DiscountTags).HasMaxLength(50);
            entity.Property(e => e.Erpcode)
                .HasMaxLength(20)
                .HasColumnName("ERPCode");
            entity.Property(e => e.ExpiringOn).HasColumnType("datetime");
            entity.Property(e => e.FeaturesDescrip)
                .HasColumnType("text")
                .HasColumnName("featuresDescrip");
            entity.Property(e => e.IsBestDeal).HasDefaultValue(false, "DF_PItems_IsBestDeal");
            entity.Property(e => e.IsLatestArrival).HasDefaultValue(false, "DF_PItems_IsLatestArrival");
            entity.Property(e => e.ItemUnit).HasMaxLength(10);
            entity.Property(e => e.ItemUnitOfferedPrice).HasColumnType("money");
            entity.Property(e => e.ItemUnitPrice).HasColumnType("money");
            entity.Property(e => e.MetaDescription).HasMaxLength(255);
            entity.Property(e => e.MetaKeywords).HasMaxLength(255);
            entity.Property(e => e.ModifiedOn)
                .HasDefaultValueSql("(getdate())", "DF_PItems_ModifiedOn")
                .HasColumnType("datetime");
            entity.Property(e => e.NRateCounts)
                .HasDefaultValue(0L, "DF_PItems_nRateCounts")
                .HasColumnName("nRateCounts");
            entity.Property(e => e.NRating)
                .HasDefaultValue(0m, "DF_PItems_nRating")
                .HasColumnType("decimal(10, 5)")
                .HasColumnName("nRating");
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.OfferedPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pcode)
                .HasMaxLength(20)
                .HasColumnName("PCode");
            entity.Property(e => e.ReadCounts).HasDefaultValue(0L, "DF_PItems_ReadCounts_1");
            entity.Property(e => e.SellerGuid).HasColumnName("SellerGUID");
            entity.Property(e => e.ShippingDelhiNcrcharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ShippingDelhiNCRCharges");
            entity.Property(e => e.ShippingHomeCityCharges).HasColumnType("money");
            entity.Property(e => e.ShippingHomeCityDeliveryNote).HasMaxLength(255);
            entity.Property(e => e.ShippingHomeCountryCharges).HasColumnType("money");
            entity.Property(e => e.ShippingHomeCountryDeliveryNote).HasMaxLength(255);
            entity.Property(e => e.ShippingNorthIndiaCharges).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ShippingProviderCode).HasMaxLength(10);
            entity.Property(e => e.ShippingRoicharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ShippingROICharges");
            entity.Property(e => e.SpecificationsDescrip)
                .HasColumnType("text")
                .HasColumnName("specificationsDescrip");
            entity.Property(e => e.Status).HasDefaultValue(true, "DF_PItems_Status");
            entity.Property(e => e.Vat)
                .HasDefaultValue(0m, "DF_PItems_Vat")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Video).HasColumnType("text");
            entity.Property(e => e.Weight).HasComment("Weight as per product specification, later converted to required unit for the calculation of logistics requirement");
            entity.Property(e => e.WindowTitle).HasMaxLength(255);

            entity.HasOne(d => d.Brand).WithMany(p => p.Pitems)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK_PItems_PBrands");

            entity.HasOne(d => d.Cat).WithMany(p => p.Pitems)
                .HasForeignKey(d => d.CatId)
                .HasConstraintName("FK_PItems_PCategories");

            entity.HasOne(d => d.ItemUnitNavigation).WithMany(p => p.Pitems)
                .HasForeignKey(d => d.ItemUnit)
                .HasConstraintName("FK_PItems_PUnits");

            entity.HasOne(d => d.Seller).WithMany(p => p.Pitems)
                .HasForeignKey(d => d.SellerGuid)
                .HasConstraintName("FK_PItems_UsersInfo");
        });

        modelBuilder.Entity<PitemComment>(entity =>
        {
            entity.HasKey(e => e.ComId).HasName("PK_ShopItemComments");

            entity.ToTable("PItemComments");

            entity.Property(e => e.ComId).HasColumnName("comID");
            entity.Property(e => e.ComActStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("P", "DF_ShopItemComments_comActStatus")
                .HasColumnName("comActStatus");
            entity.Property(e => e.ComComments)
                .HasMaxLength(250)
                .HasColumnName("comComments");
            entity.Property(e => e.ComDate)
                .HasDefaultValueSql("(getdate())", "DF_ShopItemComments_comDate")
                .HasColumnType("datetime")
                .HasColumnName("comDate");
            entity.Property(e => e.ComEmail)
                .HasMaxLength(100)
                .HasColumnName("comEMail");
            entity.Property(e => e.ComName)
                .HasMaxLength(50)
                .HasColumnName("comName");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
        });

        modelBuilder.Entity<PitemOffer>(entity =>
        {
            entity.HasKey(e => e.OfferId);

            entity.ToTable("PItemOffers");

            entity.Property(e => e.OfferId).HasColumnName("OfferID");
            entity.Property(e => e.ExpiringDate).HasColumnType("datetime");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ItemUnit).HasMaxLength(10);
            entity.Property(e => e.OfferDescription).HasColumnType("ntext");
            entity.Property(e => e.OfferPrice).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PitemPicture>(entity =>
        {
            entity.ToTable("PItemPictures");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Caption).HasMaxLength(75);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PimageUrl)
                .HasMaxLength(50)
                .HasColumnName("PImageURL");
            entity.Property(e => e.PitemId).HasColumnName("PItemID");

            entity.HasOne(d => d.Pitem).WithMany(p => p.PitemPictures)
                .HasForeignKey(d => d.PitemId)
                .HasConstraintName("FK_PItemPictures_PItems");
        });

        modelBuilder.Entity<ProductReview>(entity =>
        {
            entity.Property(e => e.Attachment)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Review).HasColumnType("text");
            entity.Property(e => e.UserGuid).HasColumnName("UserGUID");
        });

        modelBuilder.Entity<Punit>(entity =>
        {
            entity.HasKey(e => e.UnitCode);

            entity.ToTable("PUnits");

            entity.Property(e => e.UnitCode).HasMaxLength(10);
            entity.Property(e => e.UnitMultiName).HasMaxLength(40);
            entity.Property(e => e.UnitName).HasMaxLength(35);
            entity.Property(e => e.UnitOneOrMultiName).HasMaxLength(45);
        });

        modelBuilder.Entity<ReferToFriend>(entity =>
        {
            entity.ToTable("ReferToFriend");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ReferralGuid).HasColumnName("ReferralGUID");
        });

        modelBuilder.Entity<SetLoyaltyPoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Loyalty");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.SaleValue).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<SetLoyaltyPointsValue>(entity =>
        {
            entity.ToTable("SetLoyaltyPointsValue");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.LoyaltyPointsValue).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<ShipRegionCity>(entity =>
        {
            entity.ToTable("ShipRegionCity");

            entity.Property(e => e.ShipRegionCityId).HasColumnName("ShipRegionCityID");
            entity.Property(e => e.ShipRegionId).HasColumnName("ShipRegionID");
        });

        modelBuilder.Entity<ShippingPolicy>(entity =>
        {
            entity.HasKey(e => e.PolocyId);

            entity.ToTable("ShippingPolicy");

            entity.Property(e => e.PolocyId).HasColumnName("PolocyID");
            entity.Property(e => e.Cost1).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Cost2).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Cost3).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PitmId).HasColumnName("PItmID");
            entity.Property(e => e.PolicyName).HasMaxLength(100);
        });

        modelBuilder.Entity<ShippingRegion>(entity =>
        {
            entity.HasKey(e => e.ShipRegionId);

            entity.Property(e => e.ShipRegionId).HasColumnName("ShipRegionID");
        });

        modelBuilder.Entity<ShoppingCart>(entity =>
        {
            entity.HasKey(e => e.ShopCartId);

            entity.ToTable("ShoppingCart");

            entity.Property(e => e.ShopCartId).HasColumnName("ShopCartID");
            entity.Property(e => e.AddedAt)
                .HasDefaultValueSql("(getdate())", "DF_ShoppingCart_AddedAt")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerSessionGuid).HasColumnName("CustomerSessionGUID");
            entity.Property(e => e.Discount)
                .HasDefaultValue(0m, "DF_ShoppingCart_Discount")
                .HasColumnType("decimal(6, 2)");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");
            entity.Property(e => e.OfferId)
                .HasDefaultValue(0L, "DF_ShoppingCart_OfferID")
                .HasColumnName("OfferID");
            entity.Property(e => e.PriceToPay).HasColumnType("money");
            entity.Property(e => e.SaleType).HasMaxLength(1);
            entity.Property(e => e.SavedAmount)
                .HasDefaultValue(0m, "DF_ShoppingCart_SavedAmount")
                .HasColumnType("money");
            entity.Property(e => e.TextOption).HasMaxLength(400);
            entity.Property(e => e.UnitPrice).HasColumnType("money");
            entity.Property(e => e.UnitShipping).HasColumnType("money");

            entity.HasOne(d => d.Item).WithMany(p => p.ShoppingCarts)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShoppingCart_PItems");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.StateName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UsersInfo>(entity =>
        {
            entity.HasKey(e => e.UserGuid);

            entity.ToTable("UsersInfo");

            entity.Property(e => e.UserGuid)
                .ValueGeneratedNever()
                .HasColumnName("UserGUID");
            entity.Property(e => e.BuyerTypeCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CompanyName).HasMaxLength(150);
            entity.Property(e => e.ContactNo).HasMaxLength(20);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmailAddress).HasMaxLength(150);
            entity.Property(e => e.EmailVerifyCode).HasMaxLength(10);
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.IsEmailVerified).HasColumnName("isEmailVerified");
            entity.Property(e => e.LoginOtp)
                .HasMaxLength(50)
                .HasColumnName("LoginOTP");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasDefaultValue("F", "DF_UsersInfo_MembershipType");
            entity.Property(e => e.MembershipUpdated).HasColumnType("datetime");
            entity.Property(e => e.MobileVerifyCode).HasMaxLength(10);
            entity.Property(e => e.Otpdate)
                .HasColumnType("datetime")
                .HasColumnName("OTPDate");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.SellerDiscCodes).HasMaxLength(50);
            entity.Property(e => e.SignupVia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(150);
            entity.Property(e => e.ValidUpto).HasColumnType("datetime");
        });

        modelBuilder.Entity<VwAspnetApplication>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_Applications");

            entity.Property(e => e.ApplicationName).HasMaxLength(256);
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.LoweredApplicationName).HasMaxLength(256);
        });

        modelBuilder.Entity<VwAspnetMembershipUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_MembershipUsers");

            entity.Property(e => e.Comment).HasColumnType("ntext");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");
            entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");
            entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
            entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");
            entity.Property(e => e.LoweredEmail).HasMaxLength(256);
            entity.Property(e => e.MobileAlias).HasMaxLength(16);
            entity.Property(e => e.MobilePin)
                .HasMaxLength(16)
                .HasColumnName("MobilePIN");
            entity.Property(e => e.PasswordAnswer).HasMaxLength(128);
            entity.Property(e => e.PasswordQuestion).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<VwAspnetProfile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_Profiles");

            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VwAspnetRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_Roles");

            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.LoweredRoleName).HasMaxLength(256);
            entity.Property(e => e.RoleName).HasMaxLength(256);
        });

        modelBuilder.Entity<VwAspnetUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_Users");

            entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
            entity.Property(e => e.LoweredUserName).HasMaxLength(256);
            entity.Property(e => e.MobileAlias).HasMaxLength(16);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<VwAspnetUsersInRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_UsersInRoles");
        });

        modelBuilder.Entity<VwAspnetWebPartStatePath>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_WebPartState_Paths");

            entity.Property(e => e.LoweredPath).HasMaxLength(256);
            entity.Property(e => e.Path).HasMaxLength(256);
        });

        modelBuilder.Entity<VwAspnetWebPartStateShared>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_WebPartState_Shared");

            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VwAspnetWebPartStateUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_WebPartState_User");

            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Wishlist>(entity =>
        {
            entity.ToTable("Wishlist");

            entity.Property(e => e.WishlistId).HasColumnName("WishlistID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerSessionGuid).HasColumnName("CustomerSessionGUID");
            entity.Property(e => e.PitemId).HasColumnName("PItemID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
