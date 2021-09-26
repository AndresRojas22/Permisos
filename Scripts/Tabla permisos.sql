create table Permisos(
id_Permiso int primary key,
Lectura int,
Escritura int,
Eliminacion int,
Actualizacion int,
FK_Id_Usuario int,
foreign key (Fk_Id_Usuario) references Usuarios(id_Usuario));