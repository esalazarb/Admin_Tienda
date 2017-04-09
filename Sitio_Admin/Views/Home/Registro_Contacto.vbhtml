@Code
    ViewData("Title") = "Registro_Contacto"
End Code



<div class="container-fluid">
    <hr>
    <div class="row-fluid">
        <div class="span6">
            <div class="widget-box">
                <div class="widget-title">
                    <span class="icon"> <i class="icon-align-justify"></i> </span>
                    <h5>Datos de Contacto con la Tienda</h5>
                </div>
                <div class="widget-content nopadding">
                    <form action="#" method="get" class="form-horizontal">
                        <div class="control-group">
                            <label class="control-label">Dirección:</label>
                            <div class="controls">
                                <input type="text" class="span11" placeholder="Dirección" />
                            </div>
                        </div>
                     
                        
                        <div class="control-group">
                            <label for="normal" class="control-label">Teléfonos:</label>
                            <div class="controls">
                                <input type="text" id="mask-phone" class="span8 mask text" placeholder="Teléfono">
                            </div>
                            <div class="controls">
                                <input type="text" id="mask-phone" class="span8 mask text" placeholder="Teléfono">
                            </div>
                        </div>

                        <div class="control-group">
                            <label for="normal" class="control-label">Correo:</label>
                            <div class="controls">
                                <input type="text" id="mask-phone" class="span8 mask text" placeholder="Correo">
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

</div>
