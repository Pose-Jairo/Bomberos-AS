create database Bomberito;

use Bomberito;


use master
drop database Bomberito

 
create table Jerarquia
(
id_jerarquia int identity(1,1) primary key,
Nombre varchar(50)
)

create table Persona
(
Id_persona int identity(1,1) primary key,
Nombre varchar(50),
Apellido varchar(50),
permiso bit default 0,
id_jerarquia int foreign key references jerarquia(id_jerarquia)
)

create table Areas
(
id_area int identity(1,1) primary key,
Nombre varchar(50)
)

select * Areas

/* >>> a partir de aqui no esta instanciado las siguientes tablas <<< */

create table tarea
(
id_tarea int identity(1,1) primary key,
Descripcion varchar(255),
Observacion varchar(255),
id_fecha int,
hora time,
invalida bit default 0,
id_area int,
id_persona int,
foreign key (id_area) references Areas(id_area),
foreign key (id_persona) references Persona(id_persona),
foreign key (id_fecha) references fecha(id_fecha)
)
use master
drop table tarea
drop table Areas

create table Ins_EntSal
(
id_asistencia int identity(1,1) primary key,
hora_entrada time,
hora_salida time,
id_fecha int,
Id_persona int foreign key references Persona(Id_persona),
foreign key (id_fecha) references fecha(id_fecha)
)

create table Emergencias
(
id_emergencia int identity(1,1) primary key,
id_fecha int,
hora time,
foreign key (id_fecha) references fecha(id_fecha)
)

create table Emergencia_Asist
(
id_Persona int,
id_emergencia int,
primary key(id_Persona, id_emergencia),
foreign key(id_Persona) references persona(id_Persona),
foreign key(id_emergencia) references emergencias(id_emergencia)
)


create table Reunion
(
id_reunion int identity (1,1) primary key,
id_fecha int,
descripcion varchar(255),
id_persona int,
hora time,
foreign key (Id_persona) references Persona(Id_persona),
foreign key (id_fecha) references fecha(id_fecha)
)

create table presente_institucion
(
id_present_inst int primary key identity(1,1),
id_fecha int,
hora_total int,
presente bit default(1),
foreign key (id_fecha) references fecha(id_fecha)
)

create table present_area
(
id_presentearea int identity (1,1) primary key,
puntaje int,
id_fecha int,
foreign key (id_fecha) references fecha(id_fecha)
)

create table fecha
(
id_fecha int identity(1,1) primary key,
fecha date
)

