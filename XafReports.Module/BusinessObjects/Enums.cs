using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XafReports.Module.BusinessObjects
{
    public class Enums
    {
        public enum EstadoVehiculo
        {
            DISPONIBLE,
            MANTENIMIENTO,
            RENTADO,
            INACTIVO,
            VENDIDO
        }
        public enum EstadoRentaCar
        {
            BORRADOR,
            RESERVADA,
            SALIDA,
            ENTRADA,
            FINALIZADO,
            ANULADO
        }
        public enum Parqueo
        {
            PARQUEO1,
            PARQUEO2,
            PARQUEO3,
            PARQUEO4
        }
        public enum TipoCombustible
        {
            DIESEL,
            REGULAR

        }

        public enum TipoVehiculo
        {
            SEDAN,
            PICKUP,
            CAMIONETA,
            MOTOCICLETA
        }

        public enum EstadoCobroVenta
        {
            Borrador,
            NoCobrado,
            Cobrado,
            Anulado
        }
        public enum EstadoAsignacionHabitacionLimpieza
        {
            Limpieza,
            Finalizado,
            Reasignado
        }
        public enum FuncionesUsuario
        {
            CobrarCaja,
            RecepcionistaHotel,
            LimpiezaHabitaciones,
        }
        public enum EstadoPromocion
        {
            Borrador,
            CreadaNoIniciada,
            Activo,
            NoActivo,
        }
        public enum EstadoReservacionHotel
        {
            Borrador,
            EnEspera,
            Iniciada,
            Finalizada
        }
        public enum EstadoRangoDocumento
        {
            True, False
        }

        public enum TipoAccesorio
        {
            Accesorio, Equipamiento
        }

        public enum NivelUbicionHabitacion
        {
            PrimerPlanta,
            SegundaPlanta,
            TerceraPlanta,
            Otros
        }

        public enum EstadoHabitacion
        {
            DISPONIBLE,
            RESERVADA,
            OCUPADA,
            LIMPIEZA,
            MANTENIMIENTO,
            CERRADA,
            SUPERVISION

        }
        public enum TipoHabitacion
        {
            Economica,
            Simple,
            Doble,
            Triple,
            Familiar,
            Deluxe
        }

        public enum NivelAcceso
        {
            pruebaPublico,
            publico,
            administrador
        }

        public enum EstadoVenta
        {
            Borrador,
            Anulado,
            Cancelada

        }
        public enum EstadoCobroPendiente
        {
            ACobrar,
            Cancelado,
            Anulado,
            CuentaPorCobrar,
            Liq

        }

        public enum TipoEntidad
        {
            Cliente,
            Proveedor,
            Acreedor,
            Otro

        }
        public enum TipoPersona
        {
            Natural,
            Juridica
        }

        public enum CategoriaEntidad
        {
            Excelente,
            Muy_Bueno,
            Bueno,
            Medio,
            Regular
        }
        public enum TipoPublicidad
        {
            Facebook,
            Twitter,
            Instagram,
            Booking,
            Sitio_Web,
            Otro
        }
        public enum EstadoCivil
        {
            Soltero,
            Casado,
            Acompañado,
            Viudo,
            Otro
        }

        public enum TipoDocumento
        {
            Ticket,
            Factura,
            CCF,
            Envío
            //faltan
        }

        public enum TipoServicio
        {
            Caja,
            Hotel,
            Rentacar,
            Restaurante,
            Crediprenda,
            ServiciosJuridicos,
            Agua,
            PrestamoHipotecario,
            VentaVehiculos,
            Producto,
            OtrosServicios,
            Tienda
        }
        public enum FormaDePago
        {
            Efectivo, Tarjeta, Cheque, EnLinea, CxC
        }

        public enum TipoRoles
        {
            usuarioComun,
            Administrador,

        }

        public enum PuestoTrabajo
        {
            Cajero = 0,
            Vigilante = 1,
            Recepcionista = 2,
            Cocinero = 3,
            Gerente = 4,
            Administrador = 5

        }

        public enum TipoTransaccion
        {
            CobroServicios,
            ReservacionRentaCar,
            ReservacionHotel,
            CobroCrediprenda,
            AceptarPrestamos,
            RegistroCliente,

        }

        public enum TipoContribuyente
        {
            PequeñoContribuyente,
            MedianoContribuyente,
            GranContribuyente
        }

    }
}
