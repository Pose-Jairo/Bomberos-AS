create database Bomberos

drop database Bomberos
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

SELECT * FROM bombero

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

SELECT * FROM tarea

DELETE tarea WHERE cod_tarea=6

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

select * from emergencia

update emergencia set detalle=100
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


INSERT INTO bombero (nombre, apellido, puntos_total, cod_rango, cod_area) 
VALUES 
('Luis','Araya',104,4,2),
('Manuel','Sosa',105,4,3),
('Jorge','Martinez',106,4,1),
('Ramiro','Vasquez',107,4,4),
('María','Luna',108,4,2),
('Daniel','López',109,4,1),
('Patricio','Marquez',110,4,3);



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








	-- Insert de asistencia para cada bombero durante el último mes
DECLARE @fecha_inicio DATE = DATEADD(DAY, -30, GETDATE());
DECLARE @fecha_actual DATE = GETDATE();

-- Generamos entradas de asistencia para cada bombero
WHILE @fecha_inicio <= @fecha_actual
BEGIN
    INSERT INTO asistencia (cod_bombero, fecha, entrada, salida, puntaje)
    VALUES 
        (100, @fecha_inicio, DATEADD(HOUR, 8, @fecha_inicio), DATEADD(HOUR, 16, @fecha_inicio), 10),
        (101, @fecha_inicio, DATEADD(HOUR, 9, @fecha_inicio), DATEADD(HOUR, 17, @fecha_inicio), 10),
        (102, @fecha_inicio, DATEADD(HOUR, 8, @fecha_inicio), DATEADD(HOUR, 15, @fecha_inicio), 8),
        (103, @fecha_inicio, DATEADD(HOUR, 9, @fecha_inicio), DATEADD(HOUR, 17, @fecha_inicio), 10),
        (104, @fecha_inicio, DATEADD(HOUR, 8, @fecha_inicio), DATEADD(HOUR, 16, @fecha_inicio), 10),
        (105, @fecha_inicio, DATEADD(HOUR, 10, @fecha_inicio), DATEADD(HOUR, 18, @fecha_inicio), 8),
        (106, @fecha_inicio, DATEADD(HOUR, 8, @fecha_inicio), DATEADD(HOUR, 15, @fecha_inicio), 8),
        (107, @fecha_inicio, DATEADD(HOUR, 9, @fecha_inicio), DATEADD(HOUR, 17, @fecha_inicio), 10),
        (108, @fecha_inicio, DATEADD(HOUR, 8, @fecha_inicio), DATEADD(HOUR, 16, @fecha_inicio), 10),
        (109, @fecha_inicio, DATEADD(HOUR, 9, @fecha_inicio), DATEADD(HOUR, 17, @fecha_inicio), 10);

    SET @fecha_inicio = DATEADD(DAY, 1, @fecha_inicio);
END;

-- Insert de tareas, omitiendo algunas tareas para ciertos días y bomberos
DECLARE @fecha_inicio_tarea DATE = DATEADD(DAY, -30, GETDATE());

WHILE @fecha_inicio_tarea <= @fecha_actual
BEGIN
    INSERT INTO tarea (cod_area, fecha, hora, detalle, estado, punto, total_horas, asistencia, cod_bombero)
    VALUES 
        (1, @fecha_inicio_tarea, '08:00:00', 'Tarea de emergencia', 'Completado', 5, '08:00', 1, 100),
        (2, @fecha_inicio_tarea, '09:00:00', 'Rescate', 'Completado', 8, '08:00', 1, 101),
        (1, @fecha_inicio_tarea, '10:00:00', 'Capacitación', 'Completado', 6, '06:00', 1, 102),
        (3, @fecha_inicio_tarea, '11:00:00', 'Control de incendios', 'Completado', 10, '08:00', 1, 103),
        (2, @fecha_inicio_tarea, '08:30:00', 'Simulacro', 'Completado', 7, '08:00', 1, 104),
        (1, @fecha_inicio_tarea, '10:00:00', 'Mantenimiento de equipo', 'Completado', 4, '08:00', 1, 105),
        (2, @fecha_inicio_tarea, '09:30:00', 'Capacitación', 'Completado', 6, '06:00', 1, 106),
        (1, @fecha_inicio_tarea, '10:00:00', 'Control de incendios', 'No Completado', 8, '08:00', 0, 107),  -- Falta completar
        (2, @fecha_inicio_tarea, '09:00:00', 'Tarea de entrenamiento', 'No Completado', 5, '08:00', 0, 108), -- Falta completar
        (3, @fecha_inicio_tarea, '08:00:00', 'Tarea de simulacro', 'Completado', 7, '08:00', 1, 109);

    -- Omite algunas tareas en fechas aleatorias
    IF DATEPART(DAY, @fecha_inicio_tarea) % 5 = 0
    BEGIN
        DELETE FROM tarea WHERE fecha = @fecha_inicio_tarea AND cod_bombero IN (101, 103, 105);
    END

    SET @fecha_inicio_tarea = DATEADD(DAY, 1, @fecha_inicio_tarea);
END;


SELECT 
    b.cod_bombero,
    b.nombre,
    b.apellido,
    ISNULL(SUM(DATEDIFF(MINUTE, a.entrada, a.salida)) / 60.0, 0) AS HorasTotales,
    a.fecha,
    CASE
        WHEN SUM(DATEDIFF(MINUTE, a.entrada, a.salida)) >= 60 THEN '1'
        WHEN SUM(DATEDIFF(MINUTE, a.entrada, a.salida)) < 60 AND SUM(DATEDIFF(MINUTE, a.entrada, a.salida)) > 0 THEN '0'
        ELSE 'A'
    END AS Presentismo
FROM bombero b
LEFT JOIN asistencia a ON b.cod_bombero = a.cod_bombero
GROUP BY b.cod_bombero, b.nombre, b.apellido, a.fecha
ORDER BY b.cod_bombero, a.fecha ASC

SELECT * FROM bombero
SELECT * FROM asistencia

UPDATE tarea set fecha='2024-11-01' WHERE cod_bombero=100

INSERT INTO asistencia (cod_bombero, fecha, entrada, salida, puntaje)
VALUES 
(104, '2024-11-01', '08:00:00', '16:00:00', 100),
(105, '2024-11-02', '09:00:00', '17:00:00', 90),
(106, '2024-11-03', '07:00:00', '15:00:00', 95),
(107, '2024-11-04', '06:00:00', '14:00:00', 85),
(108, '2024-11-05', '06:00:00', '14:00:00', 85),
(109, '2024-11-06', '06:00:00', '14:00:00', 85),
(110, '2024-11-07', '06:00:00', '14:00:00', 85),
(110, '2024-11-01', '08:00:00', '16:00:00', 100),
(109, '2024-11-02', '09:00:00', '17:00:00', 90),
(108, '2024-11-03', '07:00:00', '15:00:00', 95),
(107, '2024-11-04', '06:00:00', '14:00:00', 85),
(106, '2024-11-05', '06:00:00', '14:00:00', 85),
(105, '2024-11-06', '06:00:00', '14:00:00', 85),
(104, '2024-11-07', '06:00:00', '14:00:00', 85);


INSERT INTO tarea (cod_area, fecha, hora, detalle, estado, punto, total_horas, cod_bombero) VALUES 
(1, '2024-11-01', '09:00:00', 'Inspección de equipo', 'Completada', 10, '2024-10-09 10:00:00', 100),
(2, '2024-11-02', '14:00:00', 'Capacitación sobre seguridad', 'Pendiente', 8, '2024-10-08 16:00:00', 101),
(3, '2024-11-03', '12:00:00', 'Simulacro de incendio', 'Completada', 15, '2024-10-07 14:00:00', 102),
(4, '2024-11-04', '16:00:00', 'Limpieza de vehículos', 'En proceso', 5, '2024-10-06 17:30:00', 103),
(1, '2024-11-05', '09:00:00', 'Inspección de equipo', 'Completada', 10, '2024-10-09 10:00:00', 100),
(2, '2024-11-06', '14:00:00', 'Capacitación sobre seguridad', 'Pendiente', 8, '2024-10-08 16:00:00', 101),
(3, '2024-11-07', '12:00:00', 'Simulacro de incendio', 'Completada', 15, '2024-10-07 14:00:00', 102),
(4, '2024-11-01', '16:00:00', 'Limpieza de vehículos', 'En proceso', 5, '2024-10-06 17:30:00', 103),
(1, '2024-11-02', '09:00:00', 'Inspección de equipo', 'Completada', 10, '2024-10-09 10:00:00', 104),
(2, '2024-11-03', '14:00:00', 'Capacitación sobre seguridad', 'Pendiente', 8, '2024-10-08 16:00:00', 110),
(3, '2024-11-04', '12:00:00', 'Simulacro de incendio', 'Completada', 15, '2024-10-07 14:00:00', 107),
(4, '2024-11-05', '16:00:00', 'Limpieza de vehículos', 'En proceso', 5, '2024-10-06 17:30:00', 108),
(1, '2024-11-06', '09:00:00', 'Inspección de equipo', 'Completada', 10, '2024-10-09 10:00:00', 109),
(2, '2024-11-07', '14:00:00', 'Capacitación sobre seguridad', 'Pendiente', 8, '2024-10-08 16:00:00', 106),
(3, '2024-11-01', '12:00:00', 'Simulacro de incendio', 'Completada', 15, '2024-10-07 14:00:00', 105),
(4, '2024-11-02', '16:00:00', 'Limpieza de vehículos', 'En proceso', 5, '2024-10-06 17:30:00', 104);

SELECT * FROM tarea where fecha='2024-11-07'