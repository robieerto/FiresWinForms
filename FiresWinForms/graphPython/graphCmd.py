import matplotlib
import numpy as np
import matplotlib.pyplot as plt
# from scipy.interpolate import make_interp_spline, BSpline
from matplotlib.ticker import MaxNLocator
from matplotlib.ticker import FuncFormatter
from pandas import read_excel
from os import path, makedirs
import sys
import locale

locale.setlocale(locale.LC_NUMERIC, 'sk_SK.UTF-8')

timeHeader = 'Čas (s)'
valueHeader = 'Sila (N)'

graph_path = "./Data/Grafy/"

def form1(y, pos):
    """ This function returns a string with 3 decimal places, given the input x"""
    return '%.1f' % y

data = read_excel(sys.argv[1], 'Meranie '+sys.argv[2], engine='openpyxl')
# Replace commas with dots
data = data.replace(',', '.', regex=True)
data[timeHeader] = data[timeHeader].astype(float)
x = data[timeHeader]
y = data[valueHeader]
top = max(data[timeHeader])*1.005
bottom = max(data[timeHeader])*0.99

# # Returns evenly spaced numbers
# # over a specified interval.
# x_ = np.linspace(x.min(), x.max(), x.size*10)
# spl = make_interp_spline(x, y, k=3)  # type: BSpline
# y_ = spl(x_)
# plt.plot(x_, y_)

# Plot
plt.plot(x, y)
plt.xlabel(timeHeader)
plt.ylabel(valueHeader)
# formatter = FuncFormatter(form1)
# plt.gca().yaxis.set_major_formatter(FuncFormatter(formatter))
# plt.gca().get_yaxis().get_major_formatter().set_useOffset(False)
plt.gca().xaxis.set_major_locator(MaxNLocator(min_n_ticks=15))
plt.gca().yaxis.set_major_locator(MaxNLocator(integer=True))
plt.gca().set_xlim(0)
# plt.gca().set_ylim(bottom, top)
plt.grid(linestyle=':', linewidth=1)
plt.gcf().set_size_inches(12, 6)
makedirs(graph_path, exist_ok=True)
plt.subplots_adjust(left=0.055, bottom=0.085, right=0.945, top=0.945, wspace=0, hspace=0)

# plt.savefig(graph_path + '%s.png' % path.splitext(path.basename(sys.argv[1]))[0])
if (len(sys.argv) > 3):
    plt.savefig(graph_path + '%s.png' % sys.argv[2])
else:
    plt.show()
