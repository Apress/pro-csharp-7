using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IAutoLotService
{
    [OperationContract]
    void InsertCar(string make, string color, string petname);

    [OperationContract(Name = "InsertCarWithDetails")]
    void InsertCar(InventoryRecord car);

    [OperationContract]
    List<InventoryRecord> GetInventory();
}