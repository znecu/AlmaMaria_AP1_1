using AlmaMaria_AP1_1.DAL;
using AlmaMaria_AP1_1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AlmaMaria_AP1_1.Services;

public class CobroService(Contexto contexto)
{
    public async Task<bool> Guardar(Cobros cobro)
    {
        if (!await Existe(cobro.CobroId))
            return await Insertar(cobro);
        else
            return await Modificar(cobro);
    }

    private async Task<bool> Modificar(Cobros cobro)
    {
        contexto.Update(cobro);
        return await contexto.SaveChangesAsync() > 0;

    }

    private async Task<bool> Insertar(Cobros cobro)
    {
        contexto.Cobros.Add(cobro);
        return await contexto.SaveChangesAsync() > 0;
    }

    private async Task<bool> Existe(int id)
    {
        return await contexto.Cobros
            .AnyAsync(c => c.CobroId == id);

    }

    public async Task<bool> Eliminar(int id)
    {
        return await contexto.Cobros
            .AsNoTracking()
            .Where(c => c.CobroId == id)
            .ExecuteDeleteAsync() > 0;

    }

    public async Task<Cobros> Buscar(int id)
    {
        return await contexto.Cobros
            .Include(d => d.Deudores)
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.CobroId == id);
    }

    public async Task<List<Cobros>> Listar(Expression<Func<Cobros, bool>> criterio)
    {
        return await contexto.Cobros
            .Include(d => d.Deudores)
            .AsNoTracking()
            .Where(criterio)
            .ToListAsync();
    }
}
