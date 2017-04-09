@Code
    ViewData("Title") = "Registro_Categorias"
End Code



<div class="container-fluid">
    <hr>
    <div class="row-fluid">
        <div class="span6">
            <div class="widget-box">
                <div class="widget-title">
                    <span class="icon"> <i class="icon-align-justify"></i> </span>
                    <h5>Registro de Categorias</h5>
                </div>
                <div class="widget-content nopadding">
                    <form action="#" method="get" class="form-horizontal">
                        <div class="control-group">
                            <label class="control-label">Nombre:</label>
                            <div class="controls">
                                <input type="text" class="span11" placeholder="Nombre" />
                            </div>

                            <div class="controls">
                                <label>
                                    <input type="checkbox" name="radios" />
                                    Menú principal
                                </label>
                                
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
            <h5>Lista de Categorías</h5>
        </div>
        <div class="widget-content nopadding">
            <table class="table table-bordered table-striped">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Nombre</th>
                        <th>Menú Principal</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>1 </td>
                        <td>Mujer</td>
                        <td>si</td>
                        <td><a class="tip" href="#" title="Editar"><i class="icon-pencil"></i></a> <a class="tip" href="#" title="Eliminar"><i class="icon-remove"></i></a></td>
                    </tr>
                    <tr>
                        <td>2</td>
                        <td>Hombre</td>
                        <td>si</td>
                        <td><a class="tip"  href="#" title="Editar"><i class="icon-pencil"></i></a> <a class="tip" href="#" title="Eliminar"><i class="icon-remove"></i></a></td>

                    </tr>
                    
                </tbody>
            </table>
        </div>
    </div>

</div>