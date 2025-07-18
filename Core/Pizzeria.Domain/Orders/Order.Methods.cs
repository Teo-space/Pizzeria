namespace Pizzeria.Domain.Orders;

public sealed partial record Order : Aggregate
{

    /*
    /// <summary>
    /// Все позиции готовы
    /// </summary>
    public void MarkAsReady()
    {
        foreach (var position in Positions)
        {
            position.IsReady = true;
        }
        Date.Modified = DateTime.Now;
        Date.Ready = DateTime.Now;
    }

    /// <summary>
    /// Подтвержден менеджером
    /// </summary>
    public void SetAprove()
    {
        if (Status != OrderStatus.Pending)
        {
            throw new OrderDomainException($"Необходим статус '{OrderStatus.Pending}'");
        }
        this.Status = OrderStatus.Aproved;
        Date.Modified = DateTime.Now;
    }

    /// <summary>
    /// Отклонен менеджером
    /// </summary>
    public void SetDisaprove()
    {
        if (Status != OrderStatus.Pending)
        {
            throw new OrderDomainException($"Необходим статус '{OrderStatus.Pending}'");
        }
        this.Status = OrderStatus.Disaproved;
        Date.Modified = DateTime.Now;
    }

    /// <summary>
    /// Взят в работу
    /// </summary>
    public void SetInWork()
    {
        if (Status != OrderStatus.Aproved)
        {
            throw new OrderDomainException($"Необходим статус '{OrderStatus.Aproved}'");
        }
        this.Status = OrderStatus.InWork;
        Date.Modified = DateTime.Now;
        //Если требует приготовления то
        //SetTransferToKitchen()
        //Иначе
        //SetCollectingOrder()
    }

    /// <summary>
    /// Передан на кухню (в случае если в составе есть товары требующие приготовления
    /// </summary>
    public void SetTransferToKitchen()
    {
        if (Status != OrderStatus.InWork)
        {
            throw new OrderDomainException($"Необходим статус '{OrderStatus.InWork}'");
        }
        this.Status = OrderStatus.CookingPending;
        Date.Modified = DateTime.Now;
        //Create Cooking
    }
    /// <summary>
    /// Готовится на кухне
    /// </summary>
    public void SetCooking()
    {
        if (Status != OrderStatus.CookingPending)
        {
            throw new OrderDomainException($"Необходим статус '{OrderStatus.CookingPending}'");
        }
        this.Status = OrderStatus.Cooking;
        Date.Modified = DateTime.Now;
    }
    /// <summary>
    /// Приготовлен на кухне
    /// </summary>
    public void SetCookingReady()
    {
        if (Status != OrderStatus.Cooking)
        {
            throw new OrderDomainException($"Необходим статус '{OrderStatus.Cooking}'");
        }
        this.Status = OrderStatus.CookingReady;
        Date.Modified = DateTime.Now;
    }
    /// <summary>
    /// Передан наборщикам
    /// </summary>
    public void SetCollectingOrder()
    {
        if (Status != OrderStatus.CookingReady)
        {
            throw new OrderDomainException($"Необходим статус '{OrderStatus.CookingReady}'");
        }
        this.Status = OrderStatus.CollectingOrder;
        Date.Modified = DateTime.Now;
    }
    /// <summary>
    /// Передан в доставку
    /// </summary>
    public void SetTransferredToDelivery()
    {
        if (Status != OrderStatus.CollectingOrder)
        {
            throw new OrderDomainException($"Необходим статус '{OrderStatus.CollectingOrder}'");
        }
        this.Status = OrderStatus.DeliveryPending;
        Date.Modified = DateTime.Now;
    }
    /// <summary>
    /// В процессе доставки
    /// </summary>
    public void SetDelivering()
    {
        if (Status != OrderStatus.DeliveryPending)
        {
            throw new OrderDomainException($"Необходим статус '{OrderStatus.DeliveryPending}'");
        }
        this.Status = OrderStatus.Delivering;
        Date.Modified = DateTime.Now;
    }
    /// <summary>
    /// Доставлен
    /// </summary>
    public void SetDelivered()
    {
        if (Status != OrderStatus.Delivering)
        {
            throw new OrderDomainException($"Необходим статус '{OrderStatus.Delivering}'");
        }
        this.Status = OrderStatus.Delivered;
        Date.Modified = DateTime.Now;
    }

    */


}
