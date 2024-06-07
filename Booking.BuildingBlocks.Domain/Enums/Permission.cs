namespace Booking.BuildingBlocks.Domain.Enums
{
    public enum Permission
    {
        GetHostReservations = 1,
        GetGuestReservations = 2,
        GuestReservationOperations = 3,
        HostReservationOperations = 4,
        HostAccommodationOperations = 5,
        ChangeUserInfo = 6,
        SubscriptionOperations = 7,
        GuestReservationPayment = 8,
        HostReservationPayment = 9,
        ReservationOperations = 10,
        InvoicesOperations = 11,
        CreateReview = 12,
    }
}
