import kotlin.math.pow

fun main(){
    println("введите X")
    var x = readLine()!!.toDouble()
    when{
        x<3.2 -> println(x.pow(4)+9)
        x>=3.2 ->println(54*x.pow(4)/-5*x.pow(2)+7)
        else -> println("введено неверное значение")
    }

}