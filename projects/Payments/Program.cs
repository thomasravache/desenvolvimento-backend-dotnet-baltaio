using System;

namespace Payments
{
  class Program
  {
    static void Main(string[] args)
    {
      var room = new Room(3);
      room.RoomSoldOutEvent += OnRoomSoldOut;

      room.ReserveSeat();
      room.ReserveSeat();
      room.ReserveSeat();
      room.ReserveSeat();
    }

    static void OnRoomSoldOut(object sender, EventArgs e)
    {
      Console.WriteLine("Sala lotada!");
    }
  }

  public class Room
  {
    public Room(int seats)
    {
      Seats = seats;
      seatsInUse = 0;
    }

    private int seatsInUse = 0;
    public int Seats { get; set; }

    public void ReserveSeat()
    {
      seatsInUse++;

      if (seatsInUse >= Seats)
      {
        OnRoomSoldOut(EventArgs.Empty);
      }
      else
      {
        Console.WriteLine("Assento reservado.");
      }
    }

    // assinatura do  evento em si
    public event EventHandler RoomSoldOutEvent;

    // manipulador do evento
    protected virtual void OnRoomSoldOut(EventArgs e)
    {
      EventHandler handler = RoomSoldOutEvent;
      handler?.Invoke(this, e);
    }
  }
}