## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.ObjectMapperBenchmarks.FerrisSingleProperty()
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rdx+10]
       mov       rdx,[rdx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD06AEEBC8]; Ferris.Json.JsonTransform.ToJson(System.Object)
       nop
       add       rsp,28
       ret
; Total bytes of code 29
```
```assembly
; Ferris.Json.JsonTransform.ToJson(System.Object)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,128
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       vmovdqa   xmmword ptr [rsp+rax+140],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rsp+120],rax
       mov       rbx,rdx
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+0E8]
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFD068466D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+0F8],0
       je        near ptr M01_L26
       cmp       dword ptr [rsp+0F8],1
       jne       near ptr M01_L27
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,[rsp+0F0]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
M01_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       test      edx,edx
       je        near ptr M01_L28
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       xor       ebp,ebp
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L21
M01_L03:
       mov       ecx,ebp
       mov       r14,[rsi+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [r14],rcx
       jne       near ptr M01_L30
       mov       rcx,r14
       cmp       qword ptr [rcx+18],0
       je        near ptr M01_L29
       mov       rcx,[r14+18]
M01_L04:
       test      rcx,rcx
       je        near ptr M01_L65
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFD06AE3180]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       r15,rax
M01_L05:
       xor       ecx,ecx
       mov       [rsp+100],rcx
       mov       rcx,1ACFD801DD0
       mov       r13,[rcx]
       mov       rcx,r13
       mov       edx,100
       call      qword ptr [7FFD06AD9EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+108],rax
       test      rax,rax
       je        near ptr M01_L31
       lea       r12,[rax+10]
       mov       eax,[rax+8]
M01_L06:
       mov       [rsp+118],r12
       mov       [rsp+120],eax
       xor       r8d,r8d
       mov       [rsp+110],r8d
       mov       byte ptr [rsp+114],0
       mov       r8d,[rsp+110]
       cmp       r8d,[rsp+120]
       ja        near ptr M01_L66
       mov       rcx,[rsp+118]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+120]
       sub       edx,r8d
       cmp       edx,1
       jb        near ptr M01_L32
       mov       r8,1AC80208734
       movzx     edx,word ptr [r8]
       mov       [rcx],dx
       mov       r8d,[rsp+110]
       inc       r8d
       mov       [rsp+110],r8d
M01_L07:
       mov       r8,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [r14],r8
       jne       near ptr M01_L34
       mov       r12,[r14+8]
       test      r12,r12
       je        near ptr M01_L33
M01_L08:
       cmp       byte ptr [rsp+114],0
       jne       near ptr M01_L35
M01_L09:
       test      r12,r12
       je        near ptr M01_L35
       mov       r8d,[rsp+110]
       cmp       r8d,[rsp+120]
       ja        near ptr M01_L66
       mov       rcx,[rsp+118]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+120]
       sub       edx,r8d
       cmp       [r12+8],edx
       ja        near ptr M01_L35
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFD069A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rsp+110]
       add       edx,[r12+8]
       mov       [rsp+110],edx
M01_L10:
       mov       edx,[rsp+110]
       cmp       edx,[rsp+120]
       ja        near ptr M01_L66
       mov       rcx,[rsp+118]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+120]
       sub       eax,edx
       cmp       eax,3
       jb        near ptr M01_L36
       mov       rdx,1AC8020874C
       mov       eax,[rdx]
       mov       r8d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r8d
       mov       edx,[rsp+110]
       add       edx,3
       mov       [rsp+110],edx
       mov       [rsp+0C0],r15
       cmp       byte ptr [rsp+114],0
       jne       near ptr M01_L37
M01_L11:
       mov       rdx,[rsp+0C0]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFD068F4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L23
       xor       r8d,r8d
       mov       [rsp+0B8],r8
       lea       r8,[rsp+0C0]
       cmp       qword ptr [rsp+0B8],0
       jne       short M01_L12
       mov       r8,[r8]
       mov       [rsp+0B8],r8
       lea       r8,[rsp+0B8]
       cmp       qword ptr [rsp+0B8],0
       je        near ptr M01_L38
M01_L12:
       mov       rcx,[r8]
       mov       r8,offset MT_System.String
       cmp       [rcx],r8
       jne       near ptr M01_L39
M01_L13:
       mov       r15,rcx
M01_L14:
       test      r15,r15
       je        short M01_L15
       mov       r8d,[rsp+110]
       cmp       r8d,[rsp+120]
       ja        near ptr M01_L66
       mov       rcx,[rsp+118]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+120]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M01_L40
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFD069A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+110]
       add       ecx,[r15+8]
       mov       [rsp+110],ecx
M01_L15:
       xor       ecx,ecx
       mov       [rsp+0B8],rcx
       mov       ecx,[rsp+110]
       cmp       ecx,[rsp+120]
       ja        near ptr M01_L66
       mov       rax,[rsp+118]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+120]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L46
       mov       rcx,1AC80208734
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+110]
       inc       ecx
       mov       [rsp+110],ecx
M01_L16:
       mov       ecx,[rsp+110]
       cmp       ecx,[rsp+120]
       ja        near ptr M01_L66
       mov       rax,[rsp+118]
       mov       [rsp+60],rax
       mov       [rsp+68],ecx
       lea       rcx,[rsp+60]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r15,rax
       mov       r12,[rsp+108]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+100],ymm0
       vmovdqu   xmmword ptr [rsp+118],xmm0
       test      r12,r12
       je        near ptr M01_L19
       mov       ecx,[r12+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,7FFD06835120
       mov       edx,0A
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M01_L41
M01_L17:
       xor       eax,eax
       mov       dword ptr [rsp+0A8],1
       mov       edx,[rcx+8]
       cmp       edx,r14d
       jbe       short M01_L18
       mov       dword ptr [rsp+0AC],1
       mov       edx,10
       shlx      edx,edx,r14d
       cmp       [r12+8],edx
       jne       near ptr M01_L67
       mov       edx,r14d
       shl       rdx,4
       lea       r10,[rcx+rdx+10]
       mov       [rsp+48],r10
       mov       r9,[r10]
       mov       [rsp+40],r9
       mov       rcx,r10
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+48]
       mov       [rdx+8],ecx
       mov       rax,[rsp+40]
       test      rax,rax
       mov       [rsp+40],rax
       mov       eax,[rsp+0AC]
       jne       near ptr M01_L42
M01_L18:
       mov       rcx,1ACFD8005D0
       mov       r10,[rcx]
       cmp       byte ptr [r10+9D],0
       jne       near ptr M01_L59
M01_L19:
       mov       rdx,r15
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M01_L64
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       cmp       eax,[rcx+8]
       jae       near ptr M01_L68
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L20:
       inc       ebp
       cmp       [rsi+8],ebp
       jg        near ptr M01_L03
M01_L21:
       mov       rdx,rdi
       mov       rcx,1AC80200C60
       call      qword ptr [7FFD068F6DC0]; System.String.Join(System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rbx,rax
       test      rbx,rbx
       je        near ptr M01_L24
       mov       r13d,[rbx+8]
       test      r13d,r13d
       je        near ptr M01_L24
       mov       ecx,r13d
       add       rcx,2
       cmp       rcx,7FFFFFFF
       jg        near ptr M01_L25
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       [r14],r14b
       lea       r8,[r14+0C]
       mov       rcx,1AC8020876C
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r14+0E]
       lea       rdx,[rbx+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFD069A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       inc       r13d
       movsxd    rax,r13d
       lea       rax,[r14+rax*2+0C]
       mov       rdx,1AC80208784
       movzx     r8d,word ptr [rdx]
       mov       [rax],r8w
       mov       rax,r14
M01_L22:
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L23:
       mov       rdx,[rsp+0C0]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFD068F4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L45
       mov       rdx,[rsp+0C0]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFD068F43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r8,[rsp+100]
       mov       r11,7FFD067B0540
       xor       edx,edx
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M01_L14
M01_L24:
       mov       rcx,1AC80208760
       mov       rdx,1AC80208778
       call      qword ptr [7FFD068F6B08]; System.String.Concat(System.String, System.String)
       jmp       near ptr M01_L22
M01_L25:
       call      qword ptr [7FFD06A9EF40]
       int       3
M01_L26:
       mov       rdx,1ACFD801E18
       mov       rsi,[rdx]
       jmp       near ptr M01_L01
M01_L27:
       lea       rdx,[rsp+0E8]
       mov       r8d,[rsp+0F8]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFD06ACFA68]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rsp+0F8]
       mov       [rsp+0FC],ecx
       mov       rsi,[rsp+0E8]
       jmp       near ptr M01_L01
M01_L28:
       mov       rcx,1ACFD801DE8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L29:
       xor       ecx,ecx
       jmp       near ptr M01_L04
M01_L30:
       mov       rcx,r14
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax+38]
       mov       r15,rax
       jmp       near ptr M01_L05
M01_L31:
       xor       r12d,r12d
       xor       eax,eax
       jmp       near ptr M01_L06
M01_L32:
       lea       rcx,[rsp+100]
       mov       rdx,1AC80208728
       call      qword ptr [7FFD06A258F0]
       jmp       near ptr M01_L07
M01_L33:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+0D8],xmm0
       mov       rdx,[r14+48]
       lea       rcx,[rsp+0D8]
       call      qword ptr [7FFD06AF6AA8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rsp+0D8]
       vmovups   [rsp+0C8],xmm0
       lea       rcx,[rsp+0C8]
       call      qword ptr [7FFD06AF6B20]; System.MdUtf8String.ToString()
       mov       r12,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L08
M01_L34:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r12,rax
       cmp       byte ptr [rsp+114],0
       je        near ptr M01_L09
M01_L35:
       lea       rcx,[rsp+100]
       mov       rdx,r12
       call      qword ptr [7FFD06A25848]
       jmp       near ptr M01_L10
M01_L36:
       lea       rcx,[rsp+100]
       mov       rdx,1AC80208740
       call      qword ptr [7FFD06A258F0]
       mov       [rsp+0C0],r15
       cmp       byte ptr [rsp+114],0
       je        near ptr M01_L11
M01_L37:
       lea       rcx,[rsp+100]
       mov       r8,[rsp+0C0]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendCustomFormatter[[System.Object, System.Private.CoreLib]](System.Object, System.String)
       xor       r9d,r9d
       call      qword ptr [7FFD06E3C720]
       jmp       near ptr M01_L15
M01_L38:
       xor       r15d,r15d
       jmp       near ptr M01_L14
M01_L39:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M01_L13
M01_L40:
       lea       rcx,[rsp+100]
       mov       rdx,r15
       call      qword ptr [7FFD06A258F0]
       jmp       near ptr M01_L15
M01_L41:
       mov       rcx,r13
       call      qword ptr [7FFD06ACD860]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M01_L17
M01_L42:
       mov       rcx,[r13+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M01_L68
       mov       edx,r14d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       mov       [rsp+0AC],eax
       jne       short M01_L43
       mov       rcx,r13
       mov       edx,r14d
       call      qword ptr [7FFD06ACD7E8]
       mov       r10,rax
M01_L43:
       mov       r10,[r10+8]
       mov       [rsp+38],r10
       mov       rcx,7FFD06835120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFD06835C38],0
       je        near ptr M01_L47
       call      qword ptr [7FFD068FDC98]
       mov       edx,eax
       mov       [rsp+90],edx
       jmp       near ptr M01_L50
M01_L44:
       lea       rcx,[rsp+100]
       call      qword ptr [7FFD06A25938]
M01_L45:
       mov       rdx,[rsp+0C0]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFD068F43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       edx,[rsp+110]
       cmp       edx,[rsp+120]
       ja        near ptr M01_L66
       mov       r9,[rsp+118]
       mov       r8d,edx
       lea       r9,[r9+r8*2]
       mov       r8d,[rsp+120]
       sub       r8d,edx
       xor       edx,edx
       mov       [rsp+70],r9
       mov       [rsp+78],r8d
       mov       [rsp+60],rdx
       xor       edx,edx
       mov       [rsp+68],edx
       mov       rdx,[rsp+100]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+70]
       lea       r9,[rsp+60]
       lea       r8,[rsp+0B0]
       mov       r11,7FFD067B0548
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L44
       mov       ecx,[rsp+110]
       add       ecx,[rsp+0B0]
       mov       [rsp+110],ecx
       jmp       near ptr M01_L15
M01_L46:
       lea       rcx,[rsp+100]
       mov       rdx,1AC80208728
       call      qword ptr [7FFD06A258F0]
       jmp       near ptr M01_L16
M01_L47:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rsp+8C],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rsp+8C]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M01_L48
       call      qword ptr [7FFD06E3C558]
       mov       edx,eax
       jmp       short M01_L49
M01_L48:
       mov       edx,ecx
       sar       edx,10
M01_L49:
       mov       [rsp+90],edx
M01_L50:
       mov       rcx,7FFD06835120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rsp+90]
       xor       edx,edx
       div       dword ptr [7FFD06835C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L57
M01_L51:
       cmp       eax,[r8+8]
       jae       near ptr M01_L68
       mov       [rsp+98],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+30],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+88],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rsp+84],r10d
       cmp       [rcx+8],r10d
       jbe       short M01_L53
       test      r10d,r10d
       jne       short M01_L54
       xor       edx,edx
       mov       [rax+14],edx
M01_L52:
       movsxd    rdx,r10d
       mov       r8,[rsp+40]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+84]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+88],1
M01_L53:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rsp+88]
       test      ecx,ecx
       je        short M01_L55
       mov       r8d,1
       jmp       short M01_L58
M01_L54:
       jmp       short M01_L52
M01_L55:
       mov       eax,[rsp+98]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rsp+38]
       cmp       [rcx+8],r8d
       jne       short M01_L56
       xor       r8d,r8d
M01_L56:
       mov       edx,[rsp+94]
       inc       edx
       mov       eax,r8d
M01_L57:
       mov       r8,[rsp+38]
       mov       [rsp+94],edx
       cmp       [r8+8],edx
       jg        near ptr M01_L51
       xor       r8d,r8d
M01_L58:
       mov       eax,r8d
       mov       [rsp+0A8],eax
       mov       eax,[rsp+0AC]
       jmp       near ptr M01_L18
M01_L59:
       mov       rdx,r10
       mov       r8d,eax
       mov       eax,[rsp+0A8]
       cmp       dword ptr [r12+8],0
       mov       [rsp+58],rdx
       mov       [rsp+0AC],r8d
       mov       [rsp+0A8],eax
       je        near ptr M01_L19
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+0A4],eax
       mov       edx,[r12+8]
       mov       [rsp+0A0],edx
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+58]
       mov       r8d,[rsp+0A4]
       mov       r9d,[rsp+0A0]
       mov       edx,3
       call      qword ptr [7FFD069A7678]
       mov       eax,[rsp+0AC]
       test      [rsp+0A8],eax
       mov       [rsp+0AC],eax
       jne       near ptr M01_L19
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[r12+8]
       mov       rdx,[rsp+58]
       mov       [rsp+50],rdx
       mov       [rsp+9C],eax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,[rsp+0AC]
       test      r13d,r13d
       jne       short M01_L60
       mov       r14,[rsp+50]
       mov       edx,[rsp+9C]
       mov       ecx,0FFFFFFFF
       jmp       short M01_L61
M01_L60:
       mov       rdx,[rsp+50]
       mov       ecx,[rsp+9C]
       mov       r8d,ecx
       mov       ecx,r14d
       mov       r14,rdx
       mov       edx,r8d
M01_L61:
       mov       r8d,r12d
       mov       r9d,eax
       test      r13d,r13d
       jne       short M01_L62
       mov       eax,1
       jmp       short M01_L63
M01_L62:
       xor       eax,eax
M01_L63:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FFD06ACE2B0]
       jmp       near ptr M01_L19
M01_L64:
       mov       rcx,rdi
       call      qword ptr [7FFD069AE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L20
M01_L65:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD06D1D0F8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD068FF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L66:
       call      qword ptr [7FFD06A9E9D0]
       int       3
M01_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD06D1F378]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFD067A4000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD068FF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L68:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3348
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.ObjectMapperBenchmarks.NewtonsoftSingleProperty()
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+8]
       call      qword ptr [7FFD06D469D0]; Newtonsoft.Json.JsonSerializer.CreateDefault()
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD06D44420]; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; Newtonsoft.Json.JsonSerializer.CreateDefault()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rcx,18960C04E38
       mov       rax,[rcx]
       test      rax,rax
       jne       short M01_L02
       xor       ebx,ebx
M01_L00:
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD06D46988]; Newtonsoft.Json.JsonSerializer..ctor()
       test      rbx,rbx
       jne       short M01_L03
M01_L01:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFD06D46A00]
       jmp       short M01_L01
; Total bytes of code 94
```
```assembly
; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edx,100
       mov       dword ptr [r14+20],7FFFFFFF
       cmp       edx,400
       jl        near ptr M02_L04
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M02_L00:
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,18960C00428
       mov       r13,[rcx]
       mov       rcx,18960C014E8
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,18900301C08
       mov       [r15+10],rcx
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+28],1
       mov       [rbp-38],r15
       mov       rcx,offset MT_Newtonsoft.Json.JsonTextWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       [r14+24],ecx
       mov       dword ptr [r14+2C],3
       mov       byte ptr [r14+38],1
       mov       byte ptr [r14+39],1
       lea       rcx,[r14+58]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       word ptr [r14+8E],22
       mov       byte ptr [r14+91],1
       mov       word ptr [r14+8C],20
       mov       dword ptr [r14+88],2
       mov       ecx,[r14+30]
       mov       rdx,18960C05028
       mov       rax,18960C05030
       cmp       ecx,2
       mov       rdx,[rdx]
       cmove     rdx,[rax]
       lea       rcx,[r14+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],1
       mov       [rbp-40],r14
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       cmp       [rbx],rcx
       jne       short M02_L02
       mov       r13d,[rbx+94]
       jmp       short M02_L03
M02_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,146
       mov       rdx,7FFD06D1B718
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD069DD458]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       mov       r13d,eax
M02_L03:
       test      r13d,r13d
       jl        short M02_L01
       cmp       r13d,1
       jg        short M02_L01
       mov       [r14+24],r13d
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rax,[rbx]
       mov       rax,[rax+80]
       call      qword ptr [rax+18]
       nop
       mov       rcx,rsp
       call      M02_L05
       nop
       mov       r15,[rbp-38]
       mov       rcx,[r15+20]
       cmp       [rcx],ecx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFD06B6A470]; System.Text.StringBuilder.ToString()
M02_L04:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M02_L00
M02_L05:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       r14,[rbp-40]
       cmp       dword ptr [r14+20],8
       je        near ptr M02_L15
       cmp       byte ptr [r14+39],0
       je        short M02_L11
       jmp       short M02_L07
M02_L06:
       mov       edx,[r14+48]
       mov       rcx,r14
       call      qword ptr [7FFD06D4EB50]
M02_L07:
       mov       rax,[r14+8]
       test      rax,rax
       jne       short M02_L08
       xor       r15d,r15d
       jmp       short M02_L09
M02_L08:
       mov       ecx,[rax+10]
       mov       r15d,ecx
M02_L09:
       cmp       dword ptr [r14+48],0
       je        short M02_L10
       inc       r15d
M02_L10:
       test      r15d,r15d
       jg        short M02_L06
M02_L11:
       mov       rdx,[r14+70]
       test      rdx,rdx
       je        short M02_L13
       mov       rcx,[r14+78]
       test      rcx,rcx
       je        short M02_L12
       mov       r11,7FFD067E0B88
       call      qword ptr [r11]
M02_L12:
       xor       ecx,ecx
       mov       [r14+70],rcx
M02_L13:
       cmp       byte ptr [r14+38],0
       je        short M02_L15
       mov       rcx,[r14+58]
       test      rcx,rcx
       je        short M02_L15
       mov       rax,offset MT_System.IO.StringWriter
       cmp       [rcx],rax
       jne       short M02_L14
       mov       byte ptr [rcx+28],0
       jmp       short M02_L15
M02_L14:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
M02_L15:
       mov       rcx,r14
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 774
```

