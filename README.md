---

## 🛠️ Tecnologías Utilizadas

- **Lenguaje:** C# .NET 8
- **UI:** Windows Forms con [Guna.UI2.WinForms](https://github.com/ramik-11/Guna.UI2.WinForms)
- **Base de Datos:** SQL Server
- **ORM:** ADO.NET
- **Seguridad:** Hashing SHA-256 para contraseñas
- **Multilenguaje:** JSON (Español / Inglés)

---

## 🧪 Para probar el sistema

1. Clona este repositorio.
2. Restaura las referencias NuGet (`Guna.UI2.WinForms`, si es necesario).
3. Crea la base de datos con el script `ManagementSystemDB.sql`.
4. Ajusta tu `App.config` para la cadena de conexión.
5. Corre el proyecto desde `PresentationLayer`.

---

## 👤 Usuarios por defecto

| Usuario   | Contraseña | Rol       |
|-----------|-------------|------------|
| `ad`      | `123`       | `Admin`    |
| `cashier` | `123`       | `Cashier`  |

---

## 💡 Mejoras futuras (TODO)

- Integración con reportes en PDF.
- Autenticación con tokens o JWT.
- Gestión de clientes más detallada.
- Historial completo de ventas y devoluciones.

---

## 📄 Licencia

Proyecto desarrollado para fines académicos y de aprendizaje. Puedes adaptarlo y extenderlo según tus necesidades.
