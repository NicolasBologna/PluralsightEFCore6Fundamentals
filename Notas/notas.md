ctrl + shift + p to paste images

![](2022-06-02-17-38-26.png)

![](2022-06-21-11-32-50.png) las queries las cachea

## EF.Functions

![](2022-06-21-11-42-30.png)
Piola las functions porque te permiten tirar queries mas cercanas a SQL y usar comodines.

![](2022-06-21-13-48-44.png)
Find es de EF Core, no de LINQ. No podes meterle LINQ despues

![](2022-06-21-13-50-01.png)
Mucho más performante para paginar!

# OJO CON EL ORDENAMIENTO EN LINQ:
![](2022-06-21-14-08-26.png)


![](2022-06-21-14-10-14.png)

![](2022-06-21-14-50-49.png)

# Tracking state y performance.

Se puede poner el noTracking desde la query o por default en el context, después podes forzar a trackear algo desde la query con AsTracking()
![](2022-06-21-14-55-51.png)

![](2022-06-21-15-14-59.png)

# Agregando data

![](2022-06-21-15-20-38.png)

## DebugView para EF
_context.ChangeTracker.DebugView.ShortView/LongView -> ta bueno esto 


# Trabajando con aplicaciones offline
![](2022-06-21-15-47-46.png)

Acá se ve como trae el objeto, lo usa en otro lado y después le dice a EF que actualice en base al objeto q le pasas.
![](2022-06-21-15-49-39.png)

![](2022-06-21-15-59-46.png)

# Migrations

![](2022-06-22-10-07-19.png)
-idempotent se asegura que lo que vayas a agregar no exista

## Para hacer un scaffold de una base ya existente

![](2022-06-22-10-13-12.png)

## Cómo modificar el comportamiento de EF

![](2022-06-22-11-05-35.png)

## 1-to-Many

![](2022-06-22-11-39-55.png)

# Loggin

![](2022-06-22-12-19-01.png)

![](2022-06-22-12-21-59.png)

# Agregar data en relaciones

![](2022-06-22-13-16-02.png)

![](2022-06-22-13-36-41.png)

Cuando hacemos un Include también podemos meterle LINQ a la entidad hija!
![](2022-06-22-13-40-18.png)

OJO con el órden y las mezclas

![](2022-06-22-13-41-45.png)

![](2022-06-22-13-43-24.png)