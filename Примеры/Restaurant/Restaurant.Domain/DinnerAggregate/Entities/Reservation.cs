using Restaurant.Domain.BillAggregate.ValueObjects;
using Restaurant.Domain.Common.Models;
using Restaurant.Domain.DinnerAggregate.ValueObjects;
using Restaurant.Domain.GuestAggregate.ValueObjects;

namespace Restaurant.Domain.DinnerAggregate.Entities;

public sealed class Reservation : Entity<ReservationId>
{
    public int GuestCount { get; }
    public string ReservationStatus { get; }
    public GuestId GuestId { get; }
    public BillId BillId { get; }
    public DateTime? ArrivalDateTime { get; private set; }
    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    private Reservation(
        ReservationId reservationId,
        int guestCount,
        string reservationStatus,
        GuestId guestId,
        BillId billId,
        DateTime createdDateTime,
        DateTime updatedDateTime)
    : base(reservationId)
    {
        GuestCount = guestCount;
        ReservationStatus = reservationStatus;
        GuestId = guestId;
        BillId = billId;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public static Reservation Create(
        int guestCount,
        string reservationStatus,
        GuestId guestId,
        BillId billId)
    {
        return new(
            ReservationId.CreateUnique(),
            guestCount,
            reservationStatus,
            guestId,
            billId,
            DateTime.UtcNow,
            DateTime.UtcNow);
    }

    private Reservation() 
    {

    }
}