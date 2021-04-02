using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tarea9.Data.Models
{

  [Table("Solicitantes")]
  public class Solicitante
  {

    [Key, Required]
    public Guid Id { get; set; }

    [Required, StringLength(11, MinimumLength = 11)]
    public string Cedula { get; set; }

    [Required]
    public string Nombre { get; set; }

    [Required]
    public string Apellido { get; set; }

    [Required, Phone]
    public string Telefono { get; set; }

    [Required, EmailAddress]
    public string Correo { get; set; }

    [Required]
    public DateTime FechaNacimiento { get; set; }

    [Required]
    public string Sangre { get; set; }

    [Required]
    public int ProvinciaId { get; set; }

    [Required]
    public string Direccion { get; set; }

    [Required]
    public float Latitud { get; set; }

    [Required]
    public float Longitud { get; set; }

    [Required]
    public bool HaTenidoCovid { get; set; }

    [Required]
    public string Justificacion { get; set; }

    
    public virtual Provincia Provincia { get; set; }

    // public override string ToString(){
    //   return $"<h4>{Cedula}</h4><h3>{Nombre} {Apellido}</h3><h4>{FechaNacimiento.ToShortDateString()} - {Provincia.Nombre}</h4><br><h5>{Latitud}, {Longitud}</h5><h4>{Direccion}</h4><h5>{Telefono} | {Correo}</h5><br><h5>Covid: {(HaTenidoCovid? "Positivo":"Negativo")}</h5><h6>{Justificacion}</h6><br><h6>Id de la Solicitud: {Id}<h6><br>";
    // }
  }
}
