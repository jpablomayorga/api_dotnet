using webapi;
using webapi.Models;

namespace webapi.Services;
public class TareaService: ITareaService
{
    readonly TareasContext context;

    public TareaService(TareasContext dbcontext)
    {
        context = dbcontext;
    }
    public IEnumerable<Tarea> Get(){
        return context.Tareas;
    }
    /*public async Task Save(Categoria categoria)
    {
        context.Add(categoria);
        await context.SaveChangesAsync();
    }
    public async Task Update(Guid id, Categoria categoria)
    {
        var categoriaActual = context.Categorias.Find(id);
        if(categoriaActual != null)
        {
            categoriaActual.Nombre = categoria.Nombre;
            categoriaActual.Descripcion = categoria.Descripcion;
            categoriaActual.Peso = categoria.Peso;
            await context.SaveChangesAsync();
        }             
    }
     public async Task Delete(Guid id)
    {
        var categoriaActual = context.Categorias.Find(id);
        if(categoriaActual != null)
        {
            context.Remove(categoriaActual);
            await context.SaveChangesAsync();
        }     
        
    }*/
}

public interface ITareaService
{
    IEnumerable<Tarea> Get();
    /*Task Save(Categoria categoria);
    Task Update(Guid id, Categoria categoria);
    Task Delete(Guid id);*/
}