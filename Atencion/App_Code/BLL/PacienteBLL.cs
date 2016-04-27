using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;


public class PacienteBLL
{
	public PacienteBLL()
	{
	}

    public static void Insert(string nombre, string apellido)
    {
        PacienteDSTableAdapters.PacienteTableAdapter adapter = new PacienteDSTableAdapters.PacienteTableAdapter();
        adapter.Insert(nombre,apellido);

    }
    public static void Update(string nombre, string apellido,int paciente_id) 
    {
           PacienteDSTableAdapters.PacienteTableAdapter adapter = new PacienteDSTableAdapters.PacienteTableAdapter();
           adapter.Update(nombre, apellido, paciente_id);
    }
    public static void Delete(int paciente_id)
    {
       PacienteDSTableAdapters.PacienteTableAdapter adapter = new PacienteDSTableAdapters.PacienteTableAdapter();
       adapter.Delete(paciente_id);
    }
    public static List<Paciente> SelectAll() 
    {
        PacienteDSTableAdapters.PacienteTableAdapter adapter = new PacienteDSTableAdapters.PacienteTableAdapter();
        PacienteDS.PacienteDataTable table = adapter.SelectAll();
        List<Paciente> listaPacientes = new List<Paciente>();
        foreach (PacienteDS.PacienteRow row in table)
        {
            listaPacientes.Add(RowToDto(row));
        }
        return listaPacientes;

    }

    private static Paciente RowToDto(PacienteDS.PacienteRow row)
    {
        Paciente objPaciente = new Paciente();
        objPaciente.paciente_id = row.paciente_id;
        objPaciente.nombre = row.nombre;
        objPaciente.apellido = row.apellido;
        return objPaciente;
    }

    public static Paciente Select(int paciente_id) 
    {
        PacienteDSTableAdapters.PacienteTableAdapter adapter = new PacienteDSTableAdapters.PacienteTableAdapter();
        PacienteDS.PacienteDataTable table = adapter.SelectById(paciente_id);
        Paciente objPaciente = RowToDto(table[0]);
        return objPaciente;

    }
}