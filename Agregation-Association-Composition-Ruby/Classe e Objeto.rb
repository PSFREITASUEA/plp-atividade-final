class Cachorro

 def falar
  puts "Latir!"
 end

 def mover(destino)
   puts "Correndo para o #{destino}."
 end

end

snoopy = Cachorro.new
rex = Cachorro.new

snoopy.falar
rex.mover("tigela de comida")