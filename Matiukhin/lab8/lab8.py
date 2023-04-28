import time
from mrx2d.Matrix import ObservableMatrix as Matrix
from mrx2d.Drawers import ConsoleDrawer as Drawer
from multiprocessing import Process


t_start = time.time()
def colored(r, g, b, text):
    return "\033[38;2;{};{};{}m{} \033[38;2;255;255;255m".format(r, g, b, text)
_outMatrix = Matrix()
_3DMatrix = Matrix(3)
for x in [
    (a, b, c)
    for a in range(0, 255, 5)
    for b in range(0, 255, 5)
    for c in range(0, 255, 5)
]:
    _3DMatrix[x] = colored(x[0], x[1], x[2], "#")
t_gened = time.time()
_outMatrix = _3DMatrix[tuple([10])]
t_inited = time.time()
drawer = Drawer(_outMatrix)
drawer.drawAll()
t_printed = time.time()
print()
print("Generation: " + (t_gened-t_start).__str__())
print("Initializing: " + (t_inited-t_gened).__str__())
print("Printing: " + (t_printed-t_inited).__str__())
time.sleep(5)
t_start_anim = time.time()
avg_redraw = 0
for i in range(0, 255, 5):
    t_start_redraw = time.time()
    _outMatrix.set_data(_3DMatrix[tuple([i])]._data)
    t_redrawed = time.time()
    print("Redraw: " + (t_redrawed-t_start_redraw).__str__())
    avg_redraw += t_redrawed-t_start_redraw
    #time.sleep(0.05)
t_anim_end = time.time()
print("Initializing: " + (t_inited-t_gened).__str__())
print("Avg redraw: " + (avg_redraw/51).__str__())
print("FPS: " + (51/(t_anim_end-t_start_anim)).__str__())
#Move colored to tile class. In all matrix must have tiles as elements. Rewrite Drawer for it