create database Bomberos


use Bomberos


CREATE TABLE usuario_admin (
    cod_usuario INT IDENTITY(1,1),
    usuario NVARCHAR(255),
    contraseña NVARCHAR(255),
    PRIMARY KEY(cod_usuario)
)


CREATE TABLE area (
    cod_area INT IDENTITY(1,1),
    nombre NVARCHAR(255),
    PRIMARY KEY(cod_area)
)

CREATE TABLE rango (
    cod_rango INT IDENTITY(1,1),
    rango NVARCHAR(255),
    PRIMARY KEY(cod_rango)
)



CREATE TABLE emergencia (
    cod_emergencia INT IDENTITY(1,1),
    fecha DATETIME,
    inicio DATETIME,
    fin DATETIME,
    detalle NVARCHAR(MAX),
    PRIMARY KEY(cod_emergencia)
)


CREATE TABLE reunion (
    cod_reunion INT IDENTITY(1,1),
    fecha DATE,
    hora TIME,
    descripcion NVARCHAR(255),
    PRIMARY KEY(cod_reunion)
)



CREATE TABLE bombero (
    cod_bombero INT IDENTITY(100,1),
    nombre NVARCHAR(255),
    apellido NVARCHAR(255),
    puntos_total INT,
    estado BIT DEFAULT 1,
    cod_rango INT,
    cod_area INT,
    PRIMARY KEY(cod_bombero),
    FOREIGN KEY (cod_area) REFERENCES area(cod_area),
    FOREIGN KEY (cod_rango) REFERENCES rango(cod_rango)
)

SELECT tarea.cod_bombero AS Codigo, bombero.nombre AS Nombre, bombero.apellido AS Apellido, tarea.detalle AS Tarea, tarea.estado AS Estado FROM tarea INNER JOIN bombero ON bombero.cod_bombero=tarea.cod_bombero;

CREATE TABLE tarea (
    cod_tarea INT IDENTITY(1,1),
    cod_area INT,
    fecha DATE,
    hora TIME,
    detalle NVARCHAR(MAX),
    estado NVARCHAR(255),
    punto INT,
    total_horas DATETIME,
    asistencia BIT DEFAULT 1,
    cod_bombero INT,
    PRIMARY KEY(cod_tarea),
    FOREIGN KEY (cod_area) REFERENCES area(cod_area),
    FOREIGN KEY (cod_bombero) REFERENCES bombero(cod_bombero)
)



CREATE TABLE asistencia (
    cod_asistencia INT IDENTITY(1,1),
    cod_bombero INT,
    fecha DATE,
    entrada DATETIME,
    salida DATETIME,
    puntaje INT,
    PRIMARY KEY(cod_asistencia),
    FOREIGN KEY (cod_bombero) REFERENCES bombero(cod_bombero)
)

CREATE TABLE participa (
    cod_bombero INT,
    cod_reunion INT,
    PRIMARY KEY(cod_bombero, cod_reunion),
    FOREIGN KEY (cod_bombero) REFERENCES bombero(cod_bombero),
    FOREIGN KEY (cod_reunion) REFERENCES reunion(cod_reunion)
)


CREATE TABLE concurre (
    cod_bombero INT,
    cod_emergencia INT,
    PRIMARY KEY(cod_bombero, cod_emergencia),
    FOREIGN KEY (cod_bombero) REFERENCES bombero(cod_bombero),
    FOREIGN KEY (cod_emergencia) REFERENCES emergencia(cod_emergencia)
)


INSERT INTO usuario_admin (usuario, contraseña)
 VALUES 
('admin1', '1237890river'),
('admin2', '45689089boca'),
('admin3', '789899809sacachispa'),
('admin4', '32167554543racing');

INSERT INTO area (nombre) VALUES 
('furrieles'),
('guardias'),
('taller'),
('roperia'),
('capacitacion'),
('automotores'),
('edificio'),
('emergencias');


INSERT INTO rango (rango) 
VALUES 
('oficial'),
('suboficial'),
('bombero'),
('cadete');


INSERT INTO emergencia (fecha, inicio, fin, detalle) 
VALUES 
('2024-10-09', '08:30:00', '10:00:00', 'Incendio en edificio'),
('2024-10-08', '14:00:00', '15:30:00', 'Accidente de tránsito'),
('2024-10-07', '12:00:00', '13:15:00', 'Rescate de persona atrapada'),
('2024-10-06', '16:30:00', '18:00:00', 'incedio forestal');

INSERT INTO reunion (fecha, hora, descripcion) 
VALUES 
('2024-10-09', '09:00:00', 'Reunión de planificación'),
('2024-10-08', '14:30:00', 'Revisión de procedimientos de emergencia'),
('2024-10-07', '11:00:00', 'Reunión de capacitación'),
('2024-10-06', '15:00:00', 'Evaluación de recursos');



INSERT INTO bombero (nombre, apellido, puntos_total, cod_rango, cod_area) 
VALUES 
('Juan', 'Pérez', 100, 1, 1),
('María', 'López', 101, 2, 2),
('Carlos', 'Gómez', 102, 3, 3),
('Ana', 'Ramírez', 103, 4, 4);


INSERT INTO tarea (cod_area, fecha, hora, detalle, estado, punto, total_horas, cod_bombero) VALUES 
(1, '2024-10-09', '09:00:00', 'Inspección de equipo', 'Completada', 10, '2024-10-09 10:00:00', 100),
(2, '2024-10-08', '14:00:00', 'Capacitación sobre seguridad', 'Pendiente', 8, '2024-10-08 16:00:00', 101),
(3, '2024-10-07', '12:00:00', 'Simulacro de incendio', 'Completada', 15, '2024-10-07 14:00:00', 102),
(4, '2024-10-06', '16:00:00', 'Limpieza de vehículos', 'En proceso', 5, '2024-10-06 17:30:00', 103);


INSERT INTO asistencia (cod_bombero, fecha, entrada, salida, puntaje)
VALUES 
(100, '2024-10-09', '08:00:00', '16:00:00', 100),
(101, '2024-10-08', '09:00:00', '17:00:00', 90),
(102, '2024-10-07', '07:00:00', '15:00:00', 95),
(103, '2024-10-06', '06:00:00', '14:00:00', 85);

INSERT INTO participa (cod_bombero, cod_reunion)
 VALUES 
(100, 1), 
(101, 2),
(102, 3),
(103, 4);


INSERT INTO concurre (cod_bombero, cod_emergencia) VALUES 
(100, 1),
(101, 2),
(102, 3),
(103, 4);



SELECT 
    b.cod_bombero,
    b.nombre AS nombre_bombero,
    b.apellido AS apellido_bombero,
    b.puntos_total,
    r.rango,
    a.nombre AS nombre_area,
    t.cod_tarea,
    t.fecha AS fecha_tarea,
    t.hora AS hora_tarea,
    t.detalle AS detalle_tarea,
    t.estado AS estado_tarea,
    asis.fecha AS fecha_asistencia,
    asis.entrada,
    asis.salida,
    asis.puntaje,
    rec.cod_reunion,
    rec.descripcion AS descripcion_reunion,
    em.cod_emergencia,
    em.detalle AS detalle_emergencia
FROM 
    bombero b
INNER JOIN 
    rango r ON b.cod_rango = r.cod_rango
INNER JOIN 
    area a ON b.cod_area = a.cod_area
INNER JOIN 
    tarea t ON b.cod_bombero = t.cod_bombero
INNER JOIN 
    asistencia asis ON b.cod_bombero = asis.cod_bombero
INNER JOIN 
    participa p ON b.cod_bombero = p.cod_bombero
INNER JOIN 
    reunion rec ON p.cod_reunion = rec.cod_reunion
INNER JOIN 
    concurre c ON b.cod_bombero = c.cod_bombero
INNER JOIN 
    emergencia em ON c.cod_emergencia = em.cod_emergencia;

