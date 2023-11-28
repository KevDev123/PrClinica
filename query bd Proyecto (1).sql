create database Clinica
go

Use Clinica
go

create table Pacientes(
ID_Paciente int identity(1,1) primary key not null,
Nombre_Paciente Varchar(50) not null,
Apellido_Paciente Varchar (50) not null,
Fecha_Nacimiento Date,
Edad int not null,
Genero Varchar(20) not null,
Direccion Varchar(100),
Telefono_Paciente Varchar(9),
Detalles Varchar(200) --Si tiene alergias, alguna enfermedad como diabetes, hipertension etc.
)
go

create table Especialidades(
ID_Especialidad int identity(1,1) primary key not null,
Nombre_Especialidad Varchar(100) not null
)
go

create table Medicos(
ID_Medico int identity(1,1) primary key not null,
Nombre_Medico Varchar(50) not null,
Apellido_Medico varchar(50) not null,
ID_Especialidad int foreign key references Especialidades(ID_Especialidad) not null,
Telefono_Medico Varchar(9)
)
go

create table Estados(
ID_Estado int identity(1,1) primary key not null,
Estado Varchar(50) not null  --Aqui van 3 tipos de estado: Programada, Completada, Cancelada
)
go

create table Consultas(
ID_Consulta int identity(1,1) primary key not null,
ID_Paciente int foreign key references Pacientes(ID_Paciente) not null,
ID_Medico int foreign key references Medicos(ID_Medico) not null,
ID_Estado int foreign key references Estados(ID_Estado) not null,
Fecha_Consulta Datetime not null,
Observaciones Varchar(200)
)
go

Create table [Via Administracion](
ID_Via_Administracion int identity(1,1) primary key not null,
Via Varchar(50) not null
)
go

Create table Medicamentos(
ID_Medicamento int identity(1,1) primary key not null,
Nombre_Medicamento Varchar(100) not null,
ID_Via_Administracion int foreign key references [Via Administracion](ID_Via_Administracion) not null,
Fecha_Vencimiento Date,
Cantidad_Disponible int
)
go

Create table Recetas(
ID_Receta int identity(1,1) primary key not null,
ID_Consulta int foreign key references Consultas(ID_Consulta) not null,
ID_Medicamento int foreign key references Medicamentos(ID_Medicamento) not null,
Cantidad int
)
go

INSERT INTO Pacientes (Nombre_Paciente, Apellido_Paciente, Fecha_Nacimiento, Edad, Genero, Direccion, Telefono_Paciente, Detalles)
VALUES
('Juan', 'Perez', '1990-05-15', 32, 'Masculino', 'Colonia Escalón Avenida Jerusalén,Departamento de San Salvador', '123456789', 'Sin alergias'),
('María', 'Gomez', '1985-09-20', 37, 'Femenino', 'Colonia La Ceiba Avenida Roosevelt, Avenida La Ceiba, Departamento de San Miguel', '987654321', 'Diabetes tipo 2'),
('Carlos', 'Rodriguez', '1995-03-10', 28, 'Masculino', 'Plaza Principal, Ciudad San Salvador', '456789123', 'Hipertensión'),
('Santiago', 'Lemus', '1980-01-01', 43, 'Masculino', 'Calle 100, No. 100, Col. Centro, Ciudad de San Miguel', '345678887', 'Alergias a la penicilina'),
('Rosa', 'Lopez', '1985-02-02', 38, 'Femenino', 'Avenida Juárez, No. 200, Col. Roma, Departamento de San Salvador', '874567464', 'Diabetes'),
('Alejandro', 'Sánchez', '1990-03-03', 33, 'Masculino', 'Calle Reforma, No. 300, Col. Polanco, Departamento de La Libertad', '789064312', 'Hipertensión'),
('Ana', 'Flores', '1995-04-04', 28, 'Femenino', 'Avenida Insurgentes, No. 400, Col. Condesa, Departamento de Usulutan', '765434567', 'Tuberculosis'),
('José', 'Hernández', '2000-05-05', 23, 'Masculino', 'Calle Álvaro Obregón, No. 500, Col. Roma Norte, Departamento de Sonsonate', '456799348', 'Artritis reumatoide'),
('Daniel', 'Martinez', '1990-05-15', 33, 'Masculino', 'Colonia San Miguelito: Avenida Roosevelt, Avenida San Miguelito', '123506789', 'Alzheimer'),
('Marcela', 'Morales', '1985-10-20', 38, 'Femenino', 'Colonia Las Colinas: Avenida Roosevelt, Avenida Las Colinas', '677654321', 'Cancer');

	--Registros de tabla especialidades 
	INSERT INTO Especialidades (Nombre_Especialidad)
VALUES 
    ('Cardiología'),
    ('Endocrinólogo'),
    ('Dermatología'),
	('Neurologo'),
	('Reumatólogo'),
	('Cirugía'),
	('Neumólogo'),
    ('Endocrinólogo'),
    ('médico general'),
    ('Oncología');

	--registros en la tabla Medicos
    INSERT INTO Medicos (Nombre_Medico, Apellido_Medico, ID_Especialidad, Telefono_Medico)
    VALUES 
 
      ('Dr. David', 'Fernández', 1, '189456789'),
      ('Dra. Sofía', 'Martínez', 2, '987654321'),
      ( 'Dr. Daniel', 'Jiménez', 3, '456789123'),
      ( 'Dra. Laura', 'Romero', 4, '90456745'),
      ( 'Dr. Carlos', 'Castillo',5, '56450723'),
      ( 'Dra. Andrea', 'Moreno', 6, '430456047'),
      ( 'Dr. Pablo', 'Torres', 7, '889258779'),
      ( 'Dra. Alejandra', 'Álvarez', 8, '445499122'),
      ( 'Dr. Diego', 'Díaz', 9, '225407353'),
      ( 'Dra. Isabel', 'Ruiz', 10, '490423204');


    --registros de la tabla Estados
    INSERT INTO Estados (Estado)
     VALUES 
    ('Programada'),
    ('Completada'),
    ('Cancelada'),
	('Completada'),
	('Programada'),
	('Programada'),
	('Cancelada'),
	('Completada'),
	('Completada'),
	('Cancelada');

	--registros de la tabla Consultas
    
     INSERT INTO Consultas (ID_Paciente, ID_Medico, ID_Estado, Fecha_Consulta, Observaciones)
    VALUES
     (1, 9, 1, '2023-11-27', 'Consulta de rutina'),
     (2, 2, 1, '2023-11-28', 'Control de diabetes'),
     (3, 3, 1, '2023-11-29', 'Consulta de hipertensión'),
     (4, 4, 1, '2023-12-01', 'Alergias a la penicilina'),
     (5, 2, 1, '2023-12-02', 'Control de diabetes'),
     (6, 9, 1, '2023-12-03', 'Consulta de hipertensión'),
     (7, 7, 1, '2023-12-04', 'Consulta de tuberculosis'),
     (8, 5, 1, '2023-12-05', 'Consulta de artritis reumatoide'),
     (9, 4, 1, '2023-12-06', 'Consulta de Alzheimer'),
    (10, 10, 1, '2023-12-07', 'Consulta de cáncer');
 



	--registros en la tabla [Via Administracion]
    INSERT INTO [Via Administracion] (Via)
   Values
      ('Oral'),
      ('Subcutánea'),
      ('Oral'),
      ('Subcutánea'),
      ('Subcutánea'),
      ('Oral'),
      ('Intravenosa'),
      ('Intramuscular'),
      ('Intravenosa'),
      ('Intravenosa');

	-- registros en la tabla Medicamentos
     INSERT INTO Medicamentos (Nombre_Medicamento, ID_Via_Administracion, Fecha_Vencimiento, Cantidad_Disponible)
     VALUES 

    ('Metformina', 1, '2024-07-20', 50),
    ('Insulina', 2, '2024-08-20', 50 ),
    ('Captopril', 1, '2024-09-20', 100 ), 
    ('Amoxicilina', 1, '2024-10-20', 50),
    ('Insulina', 2, '2024-11-20', 50 ),
    ('Captopril', 1, '2024-12-20', 100 ), 
    ('Isoniazida', 1, '2025-01-20', 50 ),
    ('Metotrexato', 8, '2025-02-20', 50 ), 
    ('Donepezilo', 9, '2025-03-20', 50 ),
    ('Cisplatino', 9, '2025-04-20', 50 ); 

	--registros en la tabla Recetas
    INSERT INTO Recetas (ID_Consulta, ID_Medicamento, Cantidad)
    VALUES
    (2, 2, 2),
    (2, 2, 1),
    (3, 3, 3),
    (3, 4, 1),
    (5, 5, 2),
    (6, 6, 2),
    (7, 7, 1),
    (8, 8, 1),
    (8, 9, 1),
