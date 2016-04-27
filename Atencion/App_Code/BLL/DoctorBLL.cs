using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;

public class DoctorBLL
{
	public DoctorBLL()
	{
		
	}

    public static void Insertar(string nombre, string apellido, int usuario_id)
    {
        DoctorDSTableAdapters.DoctorTableAdapter adapter = new DoctorDSTableAdapters.DoctorTableAdapter();
        adapter.Insert(nombre, apellido, usuario_id);
    }
    public static void Update(string nombre, string apellido, int usuario_id,int doctor_id)
    {
        
        DoctorDSTableAdapters.DoctorTableAdapter adapter = new DoctorDSTableAdapters.DoctorTableAdapter();
        adapter.Update(nombre, apellido, usuario_id, doctor_id);
    }
    public static void Delete(int doctor_id)
    {
        DoctorDSTableAdapters.DoctorTableAdapter adapter = new DoctorDSTableAdapters.DoctorTableAdapter();
        adapter.Delete(doctor_id);
    }

    public static List<Doctor> SelectAll()
    {
        DoctorDSTableAdapters.DoctorTableAdapter adapter = new DoctorDSTableAdapters.DoctorTableAdapter();
        DoctorDS.DoctorDataTable table = adapter.SelectAll();
        List<Doctor> listaDoctores = new List<Doctor>();
        foreach (DoctorDS.DoctorRow row in table)
        {
            listaDoctores.Add(RowToDto(row));
        }
        return listaDoctores;
    }

    private static Doctor RowToDto(DoctorDS.DoctorRow row)
    {
        Doctor objDoctor = new Doctor();
        objDoctor.doctor_id = row.doctor_id;
        objDoctor.nombre = row.nombre;
        objDoctor.apellido = row.apellido;
        objDoctor.usuario_id = row.usuario_id;
        return objDoctor;

    }
    public static Doctor Select(int doctor_id)
    {
        DoctorDSTableAdapters.DoctorTableAdapter adapter = new DoctorDSTableAdapters.DoctorTableAdapter();
        DoctorDS.DoctorDataTable table = adapter.SelectById(doctor_id);
        Doctor objDoctor = RowToDto(table[0]);
        return objDoctor;   
    }
}
