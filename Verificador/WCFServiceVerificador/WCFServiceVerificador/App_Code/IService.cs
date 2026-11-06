using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IService
{
	[OperationContract]
	RespuestaServicio MantenimientoCliente(SolicitudCliente solicitud);

    [OperationContract]
    RespuestaServicio RegistrarCompra(SolicitudCompra solicitud);
}