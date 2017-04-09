@Code
    ViewData("Title") = "Registro_SubCategorias"
End Code

<div class="container-fluid">
    <hr>
    <div class="row-fluid">
        <div class="span6">
            <div class="widget-box">
                <div class="widget-title">
                    <span class="icon"> <i class="icon-align-justify"></i> </span>
                    <h5>Registro de Sub Categorias</h5>
                </div>
                <div class="widget-content nopadding">
                    <form action="#" method="get" class="form-horizontal">
                        <div class="control-group">
                            <label class="control-label">Nombre:</label>
                            <div class="controls">
                                <input type="text" class="span11" placeholder="Nombre" />
                            </div>

                            <label class="control-label">Categoría</label>
                            <div class="controls">
                                <select>
                                    <option>Mujer</option>
                                    <option>Hombre</option>
                                </select>
                            </div>


                        </div>

                        <div class="form-actions">
                            <button type="submit" class="btn btn-success">Guardar</button>
                        </div>
                    </form>
                </div>
            </div>

        </div>

    </div>

    <div class="widget-box">
        <div class="widget-title">
            <span class="icon"> <i class="icon-th"></i> </span>
            <h5>Lista de SubCategorías</h5>
        </div>
        <div class="widget-content nopadding">
            <table class="table table-bordered table-striped">
                <thead>
                    <tr>
                        <th># Categoría</th>
                        <th>Nombre Categoría</th>
                        <th># SubCategoría</th>
                        <th>Nombre SubCategoría</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>1</td>
                        <td>Mujer</td>
                        <td>1</td>
                        <td>Casual</td>
                        <td><a class="tip" href="#" title="Editar"><i class="icon-pencil"></i></a> <a class="tip" href="#" title="Eliminar"><i class="icon-remove"></i></a></td>

                    </tr>
                    <tr>
                        <td>1</td>
                        <td>Mujer</td>
                        <td>2</td>
                        <td>Formal</td>
                        <td><a class="tip" href="#" title="Editar"><i class="icon-pencil"></i></a> <a class="tip" href="#" title="Eliminar"><i class="icon-remove"></i></a></td>

                    </tr>
                    <tr>
                        <td>2</td>
                        <td>Hombre</td>
                        <td>1</td>
                        <td>Deportiva</td>
                        <td><a class="tip" href="#" title="Editar"><i class="icon-pencil"></i></a> <a class="tip" href="#" title="Eliminar"><i class="icon-remove"></i></a></td>

                    </tr>

                </tbody>
            </table>
        </div>
    </div>

</div>
